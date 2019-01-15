using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel;
using System.Threading;

namespace Model
{
    public class ElevatorSystem : InterElevatorSystem
    {
        private ElevatorManager lift = new ElevatorManager();
        private List<PassengerManager> passengers = new List<PassengerManager>();
        private Thread threadLiftMove;
        private int _numberTrip = 0;
        private int _freeTrip = 0;
        
        public event EventHandler<EventArgs> information;
        public event EventHandler<EventArgs> status;
        public event EventHandler<EventArgs> statusLift;
        public event EventHandler<EventArgs> LiftStop;
        public event EventHandler<EventArgs> finalInformation;
    
        public ElevatorSystem() { }
        public void SetFinalInfotmation()
        {
            if (finalInformation != null)
            {
                finalInformation(this, EventArgs.Empty);
            }
        
        }
        public int GetNumberTrip()
        {
            return _numberTrip;
        }
        public int getSumPass()
        {
            return passengers.Count;
        }
        public void addInformationLift(int numFloor, int capacity)
        {
            lift.setDateLift(capacity, numFloor);
        }
        public void addInformationPassenger(int id, int initialFloor, int finishFloor, int weight)
        {
            PassengerManager passenger = new PassengerManager();
            passenger.setInformation(id, initialFloor, finishFloor, weight);
            passengers.Add(passenger);
            if (information != null)
                information(this, EventArgs.Empty);
        }

        public string getInfomationPassenger()
        {
            string inf = "";
            for (int i = 0; i < passengers.Count; i++)
            {
                inf += "Passanger " + passengers[i].idPass.ToString() + " In. floor = " + passengers[i].inFloorPass.ToString() +
                    " Targ. floor = " + passengers[i].finFloorPass.ToString() + " weight = " + passengers[i].weigtPass.ToString() +
                    Environment.NewLine;
            }
            return inf;
        }
        public string getInformationCallLift()
        {
            string inf = "";
            for (int i = 0; i < passengers.Count; i++)
            {
                if (passengers[i].createPass == true && passengers[i].PositionPassenger == false && passengers[i].getDelete() == false)
                {
                    inf += "Passenger " + passengers[i].idPass.ToString() + " call the elevator " + Environment.NewLine;
                }
                if (passengers[i].PositionPassenger == true && passengers[i].getDelete() == false)
                {
                    inf += "Passenger " + passengers[i].idPass.ToString() + " enter the elevator " + Environment.NewLine;
                }
                if (passengers[i].getDelete() == true)
                {
                    inf += "Passenger " + passengers[i].idPass.ToString() + " leave the elevator " + Environment.NewLine;
                }

            }
            return inf;
        }
        public int getLiftInformation()
        {
            return lift.getNumberFloor();
        }
        public int getNumberPassenger()
        {
          
            return passengers.Count;
        }

        public int getNowLift()
        {
            return lift.getNowFloorLift();
        }
        public int getFreeTrip()
        {
            return _freeTrip;
        }
        public void Start()
        {
           
            threadLiftMove = new Thread(Move);
            threadLiftMove.Start();

        }

        public void StopThread()
        {
            threadLiftMove.Abort();
            threadLiftMove.Join();
        }
        private bool Overdrive(int Id)
        {
            WeightDetector detector = new WeightDetector(passengers, lift);
            return detector.OverloadPass(Id);
            

        }
        public int getSummWeight()
        {
            WeightDetector de = new WeightDetector(passengers, lift);
            return de.SummaryMoveWeight();
        }


        private void Move()   //  Логика лифта
        {  

            while (true) // Если никого нет ждем 
            {
                if (passengers.Count > 0) break;
                else continue;
            }

            while (true)
            {
                threadLiftStartUP(); // отвечает за перемещение вверх
                Thread.Sleep(3000); 
                threadLiftStartDown(); // ... вниз
                
            }
        }

        private void threadLiftStartUP()  // Перемещение лифта вверх
        {   
            int lifttomove = -1; // перемещение лифта к этому этажу
            int id = 0;  // номер пассажира          
            
            
                // Проверяем есть ли пассажиры в лифте
                for (int i = 0; i < passengers.Count; i++)
                {
                    if (passengers[i].PositionPassenger == true)
                    {
                        lifttomove = passengers[i].finFloorPass;
                        id = i;
                        break;
                    }
                    else
                    {
                        // Нет, идем дальше
                        lifttomove = -1;
                        continue;
                    }
                }
                
                //Если не нашли пассажира в лифте ищем нового пассажира
                if (lifttomove == -1)
                {
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        if (passengers[i].PositionPassenger == false)
                        {
                            id = i;
                            lifttomove = passengers[id].inFloorPass; 
                            break;
                        }
                    }
                    // ближайшего к лифту
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        if (passengers[id].inFloorPass > passengers[i].inFloorPass && passengers[i].PositionPassenger == false)
                        {
                            lifttomove = passengers[i].inFloorPass;
                            id = i;
                        }
                        else continue;
                    }
                }
            
           
            // Если есть пассажир в нужную сторону, перемещаемся
            // Если нет, меняем направления движения
            if (lifttomove > -1 && lifttomove >= lift.initFloor())
            {
                while (true)
                {    
                    if (status != null) // обновляем статус пассажиров во 2-м окне
                        status(this, EventArgs.Empty);

                    int k = lifttomove;

                    for (int i = lift.initFloor(); i < k; i++)
                    {   // начинаем движение к пассажиру 1
                        lift.moveUp();
                        if (statusLift != null) // обновляем статус лифта во 2-м окне
                            statusLift(this, EventArgs.Empty);
                       
                        // проверяем другие вызовы по пути
                        for (int j = 0; j < passengers.Count; j++)
                        {
                            if (lifttomove >= passengers[j].inFloorPass && passengers[j].inFloorPass >= lift.initFloor()) // между этажами
                            {
                                if (lift.initFloor() == passengers[j].inFloorPass && j != id) 
                                {   
                                    //passengers[j].PositionPassenger = true;
                                    k = passengers[j].inFloorPass; // если нашли то останавливаемся по пути
                                    // lifttomove = passengers[j].inFloorPass; 
                                    id = j;
                                }
                                if (status != null) // обновляем статус пассажиров во 2-м окне
                                    status(this, EventArgs.Empty);
                            }
                        }
                        for (int j = 0; j < passengers.Count; j++)
                        {
                            // Если нужный этаж пассажира, 
                           if (passengers[j].finFloorPass == lift.getNowFloorLift() && passengers[j].PositionPassenger == true)
                            {
                                passengers[j].PositionPassenger = false;
                                passengers[j].Delete(); // выходит
                                if (status != null)
                                    status(this, EventArgs.Empty);
                                Thread.Sleep(3000);
                                passengers.RemoveAt(j); // удаляем
                                if(id >= j) id --; // уменьшаем номер пассажира, т.к данные в листе сдвинулись
        
                            }
                            else continue;
                        }

                        if (status != null) // обновляем статус пассажиров во 2-м окне
                            status(this, EventArgs.Empty);
                    }
                    if (LiftStop != null) // обновляем статус лифта во 2-м окне
                        LiftStop(this, EventArgs.Empty);


                    if (passengers.Count <= 0) break; // если никого не осталось меняем направление, скорее всего там тоже обратно направление поменяется
                    else if (passengers[id].PositionPassenger == false && passengers.Count > 0) // если лифт подьехал к пассажиру
                    {
                        // проверяем на перегруз
                        if (Overdrive(id) == false)
                        {
                            passengers[id].PositionPassenger = true; // забираем его
                            _freeTrip++; // лифт был пустой, возможно, считаем как холостая поездка
                            if (lifttomove <= passengers[id].finFloorPass)
                            {
                                lifttomove = passengers[id].finFloorPass;
                            }
                        }
                        else // если перегруз, ищем другого пассажира, возможно неправильно, 
                        {     // т.к не учел что могут быть пассажиры в лифте, скорее всего направление два раза поменяется, поэтому должен найтись                  
                            for (int i = 0; i < passengers.Count; i++)
                            {
                                if (passengers[id].inFloorPass < passengers[i].inFloorPass && passengers[id].PositionPassenger == false  && i != id)
                                {
                                    lifttomove = passengers[i].inFloorPass; // едем до него
                                    id = i;
                                }
                                else continue;
                            }
                         }
                           // забираем и других пассажиров на этом же этаже
                            for (int j = 0; j < passengers.Count; j++)
                            {
                                if (passengers[j].inFloorPass == lift.getNowFloorLift() && j != id && Overdrive(j) == false)
                                {
                                    passengers[j].PositionPassenger = true;
                                    if (lifttomove <= passengers[j].finFloorPass)
                                    {
                                        id = j;
                                        lifttomove = passengers[id].finFloorPass;
                                    }
                                }
                            }
                            _numberTrip++; // засчитывем как поездку
                     
                    } // если лифт привез пассажира
                    else if (passengers[id].PositionPassenger == true)
                    {
                        /////////////////////////////////////////
                        // Это возможно не надо, высадка пассажиров, раньше тоже была эта проверка
                        // но возможно не всех пассажиров проверил
                        passengers[id].Delete();
                        passengers[id].PositionPassenger = false;
                        if (status != null)
                            status(this, EventArgs.Empty);
                        Thread.Sleep(3000);
                        passengers.RemoveAt(id); // высаживаем и удаляем
                        for (int j = 0; j < passengers.Count; j++)
                        {
                            if (lift.getNowFloorLift() == passengers[j].finFloorPass)
                            {
                                passengers[j].Delete();
                                passengers[j].PositionPassenger = false;
                                if (status != null)
                                    status(this, EventArgs.Empty);
                                Thread.Sleep(3000);
                                passengers.RemoveAt(j); 
                                j--;
                                break;

                            }
                        }
                        //////////////////////////////////////////////
                        if (status != null)
                            status(this, EventArgs.Empty);
                        //   int oldId = id;
                        // Довозим других пассажиров в лифте
                        for (int j = 0; j < passengers.Count; j++)
                        {
                            if (passengers[j].PositionPassenger == true && passengers[j].getDelete() == false && passengers[j].finFloorPass >= lift.initFloor())
                            {
                                id = j;
                                lifttomove = passengers[j].finFloorPass;
                                if (status != null)
                                    status(this, EventArgs.Empty);

                            }
                            if (passengers[j].inFloorPass >= lift.initFloor() && passengers[j].PositionPassenger == false && passengers[j].getDelete() == false)
                            {

                                id = j;
                                lifttomove = passengers[j].inFloorPass;
                                if (status != null)
                                    status(this, EventArgs.Empty);
                            }
                        }
                     //   if (oldId == id) break;
                        _numberTrip++;
                    }
                    if (lifttomove == lift.initFloor()) break; // не нашли никого, меняем направление
                }
            }
        }
        private void threadLiftStartDown()
        {
            int lifttomove = -1;
            int id = 0;

           
            
                // Проверяем есть ли пассажиры в лифте
                for (int i = 0; i < passengers.Count; i++)
                {
                    if (passengers[i].PositionPassenger == true )
                    {
                        lifttomove = passengers[i].finFloorPass;
                        id = i;
                        break;
                    }
                    else
                    {
                        // Нет, идем дальше
                        lifttomove = -1;
                        continue;
                    }
                }
                //Если не нашли пассажира в лифте ищем нового пассажира
                if (lifttomove == -1)
                {
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        if (passengers[i].PositionPassenger == false)
                        {
                            id = i;
                            lifttomove = passengers[id].inFloorPass;
                            break;
                        }
                    }
                    // ближайшего
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        if (passengers[id].inFloorPass < passengers[i].inFloorPass && passengers[i].PositionPassenger == false)
                        {
                            lifttomove = passengers[i].inFloorPass;
                            id = i;
                        }
                        else continue;
                    }
                }
            
            int k = lifttomove;

            if (lifttomove > -1 && lifttomove < lift.initFloor())
            {
                while (true)
                {
                    if (status != null)
                        status(this, EventArgs.Empty);

                   k = lifttomove;
                   // int oldLiftToMove = lifttomove;

                    for (int i = lift.initFloor(); i > k; i--)
                    {   // начинаем движение к пассажиру 1
                        lift.moveDown();
                        if (statusLift != null)
                            statusLift(this, EventArgs.Empty);
                        // проверяем вызовы по пути
                        for (int j = 0; j < passengers.Count; j++)
                        {
                            if (lifttomove <= passengers[j].inFloorPass && passengers[j].inFloorPass <= lift.initFloor() && passengers[j].getDelete() == false)
                            {
                                if (lift.initFloor() == passengers[j].inFloorPass && j != id)
                                {
                                    // passengers[j].positionPass = true;
                                    k = passengers[j].inFloorPass;
                                    //lifttomove = passengers[j].inFloorPass;
                                    id = j;
                                }
                                if (status != null)
                                    status(this, EventArgs.Empty);
                            }
                            // Если нужный этаж пассажира, выгоняем его
                            if (passengers[j].finFloorPass == lift.getNowFloorLift() && passengers[j].PositionPassenger == true && j != id)
                            {
                                passengers[j].PositionPassenger = false;
                                passengers[j].Delete();
                                if (status != null)
                                    status(this, EventArgs.Empty);
                                Thread.Sleep(1000);
                                passengers.RemoveAt(j);
                                if(id >= j) id--;
                                Thread.Sleep(1000);

                            }
                            else continue;
                        
                        }
                    }
                    if (LiftStop != null)
                        LiftStop(this, EventArgs.Empty);

                    if (passengers.Count <= 0) break;
                    else if (passengers[id].PositionPassenger == false)
                    {
                        if (Overdrive(id) == false && passengers[id].inFloorPass == lift.initFloor())
                        {
                            passengers[id].PositionPassenger = true;
                            _freeTrip++;
                            if (lifttomove >= passengers[id].finFloorPass)
                            {
                                lifttomove = passengers[id].finFloorPass;
                            }
                        }
                        else if (passengers[id].PositionPassenger == true)
                        {
                            for (int i = 0; i < passengers.Count; i++)
                            {
                                if (passengers[id].inFloorPass > passengers[i].inFloorPass && passengers[id].PositionPassenger == false &&
                                    passengers[i].getDelete() == false && i != id)
                                {
                                    lifttomove = passengers[i].inFloorPass;
                                    id = i;
                                }
                                else continue;
                            }
                        }
                        for (int j = 0; j < passengers.Count; j++)
                        {
                            if (passengers[j].inFloorPass == lift.getNowFloorLift() && j != id && Overdrive(j) == false)
                            {
                                passengers[j].PositionPassenger = true;
                                if (lifttomove >= passengers[j].finFloorPass) lifttomove = passengers[id].finFloorPass;
                            }
                        }

                        _numberTrip++;
                       

                    }
                    else 
                    {
                        if (lift.getNowFloorLift() == passengers[id].finFloorPass)
                        {
                            passengers[id].Delete();
                            passengers[id].PositionPassenger = false;
                            if (status != null)
                                status(this, EventArgs.Empty);
                            Thread.Sleep(1000);
                            passengers.RemoveAt(id);
                            break;
                        }

                        int oldId = id;
                        
                        for (int j = 0; j < passengers.Count; j++)
                        {
                            if(passengers[j].PositionPassenger == true && passengers[j].getDelete() == false && passengers[j].finFloorPass <= lift.initFloor())
                            {
                                id = j;
                                lifttomove = passengers[j].finFloorPass;
                                if (status != null)
                                    status(this, EventArgs.Empty);
                               
                            }

                            if (passengers[j].inFloorPass <= lift.initFloor() && passengers[j].PositionPassenger == false && passengers[j].getDelete() == false)
                            {

                                id = j;
                                lifttomove = passengers[j].inFloorPass;
                                if (status != null)
                                    status(this, EventArgs.Empty);
                            }
                        }
                        if (oldId == id) break;
                    }
                    if (lifttomove == lift.initFloor()) break;
                    _numberTrip++;
                }
        }
                
            }
        }
   
    
    }


