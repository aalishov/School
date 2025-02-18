using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Shapes
{
    public class Rectangle : IDrawable
    {
        private double height;
        private int width;

        public Rectangle(double height, int widht)
        {
            Height = height;
            Widht = widht;
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Widht
        {
            get { return width; }
            set { width = value; }
        }


        public void Draw()
        {
            DrawLine(this.width, '*', '*');

            for (int i = 1; i < this.height - 1; i++)
                DrawLine(this.width, '*', ' ');

            DrawLine(this.width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);

            for (int i = 1; i < width - 1; i++)
                Console.Write(mid);

            Console.WriteLine(end);
        }

    }
}
