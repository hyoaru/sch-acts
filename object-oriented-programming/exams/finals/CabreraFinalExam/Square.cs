using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabreraFinalExam {
    class Square : Polygon {
        private double squareSide;

        public override void ComputeArea() {
            base.ComputeArea();
            base.polygonArea = (squareSide * squareSide);
        }

        public double GetSquareSide() {
            return squareSide;
        }

        public void SetSquareSide(double squareSide) {
            this.squareSide = squareSide;
        }
    }
}
