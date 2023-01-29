using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabreraFinalExam {
    class Rectangle : Polygon {
        private double rectangleLength;
        private double rectangleWidth;

        public override void ComputeArea() {
            base.ComputeArea();
            base.polygonArea = (rectangleLength * rectangleWidth);
        }

        public double GetRectangleLength() {
            return rectangleLength;
        }

        public double GetRectangleWidth() {
            return rectangleWidth;
        }

        public void SetRectangleLength(double rectangleLength) {
            this.rectangleLength = rectangleLength;
        }

        public void SetRectangleWidth(double rectangleWidth) {
            this.rectangleWidth = rectangleWidth;
        }
    }
}
