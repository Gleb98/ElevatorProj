using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IModel
{
    public interface InterWeightDetector
    {
        bool OverloadPass(int id);
        int SummaryMoveWeight();
    }
}
