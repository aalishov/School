using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Figures
{
    public class Rectangle : IDrawable
    {
        public int Widht { get; set; }
        public int Height { get; set; }
        public void Draw()
        {
            for (int i = 0; i < this.Height; i++)
            {
                Console.WriteLine($"{new string('*', this.Widht)}");
            }            
        }
    }
}
