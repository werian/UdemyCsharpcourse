using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise16
{
    class Square
    {

        private int side;
        private int area;

        //constractor for the side
        public Square(int side)
        {
            this.side = side;
            calcArea();
        }

        // private method that calculates the area of the square
        private void calcArea()
        {
            area = side * side;
        }

        //read-only properties for the side and area
        public int Side
        {
            get { return side; }
        }
        public int Area
        {
            get { return area; }
        }
    }
}
