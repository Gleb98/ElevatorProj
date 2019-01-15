using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servises
{
    public class PassengersServices
    {
        private int _initialFloor;
        private int _finalFloor;
        private int _weight;
        private bool _create = true;
        private bool _delete;
        private bool _position = false;
        public PassengersServices() { }

        public int Id { get; set; }
        public int InitialFloor
        {
            get { return _initialFloor; }
            set { _initialFloor = value; }
        }
        public int FinalFloor
        {
            get { return _finalFloor; }
            set { _finalFloor = value; }
        }
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public bool Create
        {
            get { return _create; }
            set { _create = value; }
        }
        public bool Delete
        {
            get { return _delete; }
            set { _delete = value; }
        }
        public bool Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
