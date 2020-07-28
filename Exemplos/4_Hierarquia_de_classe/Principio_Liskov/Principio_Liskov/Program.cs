using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Liskov
{
    class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public int Area
        {
            get { return Height * Width; }
        }
    }

    class Square : Rectangle
    {
        public override int Width
        {
            get { return base.Width; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            get { return base.Height; }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect_rect = new Rectangle();
            rect_rect.Width = 10;
            rect_rect.Height = 5;
            Console.WriteLine("rect_rect Area:" + rect_rect.Area); // rect_rect Area:50

            Rectangle rect_squa = new Square();
            rect_squa.Width = 10;
            rect_squa.Height = 5;
            Console.WriteLine("rect_squa Area:" + rect_squa.Area); // rect_squa Area:25

            Square squa_squa = new Square();
            squa_squa.Width = 10;
            squa_squa.Height = 5;
            Console.WriteLine("squa_squa Area:" + squa_squa.Area); // squa_squa Area:25
            Console.ReadKey();
        }
    }
}
