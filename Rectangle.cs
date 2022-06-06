using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Rectangle
    {
        private int length { get; set; }
        private int width { get; set; }

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int l, int w)
        {
            length = l;
            width = w;
        }



        public int GetLength()
        {
            return length;
        }
        public int SetLength(int newl)
        {
            this.length = newl;
            return length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int neww)
        {
            width = neww;
            return width;
        }
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }
        public int GetArea()
        {
            return length * width;
        }
    }
}
