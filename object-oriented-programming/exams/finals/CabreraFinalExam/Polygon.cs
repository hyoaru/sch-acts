using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabreraFinalExam {
    class Polygon {
        public double polygonArea;
        public Polygon() {
            polygonArea = 0;
        }

        public virtual void ComputeArea() {}

        public double GetArea() {
            return polygonArea;
        }


    }
}
