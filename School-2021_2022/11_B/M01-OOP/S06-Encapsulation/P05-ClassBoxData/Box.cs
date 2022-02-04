using System;
namespace P05_ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return this.length; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Length cannot be zero or negative. ");
                }
                this.length = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Width cannot be zero or negative. ");
                }
                this.width = value;
            }
        }
        public  double Height
        {
            get { return this.height; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Height cannot be zero or negative. ");
                }
                this.height = value;
            }
        }

        //Volume = lwh
        //Lateral Surface Area = 2lh + 2wh
        //Surface Area = 2lw + 2lh + 2wh

        public string Volume()
        {
            return $"Volume - {this.Length * this.Width * this.Height:f2}";
        }
        public string LateralSurfaceArea()
        {
            return $"Lateral Surface Area - {2 * this.Length * this.Height + 2 * this.Width * this.Height:f2}";
        }
        public string SurfaceArea()
        {
            return $"Surface Area - {2*this.Length * this.Width + 2 * this.Length*this.Height+2*this.Width*this.Height:f2}";
        }
    }
}
