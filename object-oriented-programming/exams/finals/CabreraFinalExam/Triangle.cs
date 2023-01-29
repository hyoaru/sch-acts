using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabreraFinalExam {
    class Triangle : Polygon {
        private double triangleBase;
        private double triangleHeight;

        public override void ComputeArea() {
            base.ComputeArea();
            base.polygonArea = (triangleBase * triangleHeight) / 2;
        }

        public double GetTriangleBase() {
            return triangleBase;
        }

        public double GetTriangleHeight() {
            return triangleHeight;
        }

        public void SetTriangleBase(double triangleBase) {
            this.triangleBase = triangleBase;
        }

        public void SetTriangleHeight(double triangleHeight) {
            this.triangleHeight = triangleHeight;
        }


    }
}
