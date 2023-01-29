using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabreraFinalExam {
    public partial class MainForm : Form {
        Triangle trianglePolygon = new Triangle();
        Rectangle rectanglePolygon = new Rectangle();
        Square squarePolygon = new Square();

        public MainForm() {
            InitializeComponent();
        }

        private void btnTriangleCompute_Click(object sender, EventArgs e) {
            double triangleBase = double.Parse(txtTriangleBase.Text);
            double triangleHeight = double.Parse(txtTriangleHeight.Text);

            trianglePolygon.SetTriangleBase(triangleBase);
            trianglePolygon.SetTriangleHeight(triangleHeight);
            trianglePolygon.ComputeArea();

            double triangleArea = trianglePolygon.GetArea();
            txtTriangleArea.Text = triangleArea.ToString();
        }

        private void btnRectangleCompute_Click(object sender, EventArgs e) {
            double rectangleLength = double.Parse(txtRectangleLength.Text);
            double rectangleWidth = double.Parse(txtRectangleWidth.Text);

            rectanglePolygon.SetRectangleLength(rectangleLength);
            rectanglePolygon.SetRectangleWidth(rectangleWidth);
            rectanglePolygon.ComputeArea();

            double rectangleArea = rectanglePolygon.GetArea();
            txtRectangleArea.Text = rectangleArea.ToString();
        }

        private void btnSquareCompute_Click(object sender, EventArgs e) {
            double squareSide = double.Parse(txtSquareSide.Text);

            squarePolygon.SetSquareSide(squareSide);
            squarePolygon.ComputeArea();

            double squareArea = squarePolygon.GetArea();
            txtSquareArea.Text = squareArea.ToString();
        }
    }
}
