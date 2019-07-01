

namespace P01_Box
{
    using System;
    using System.Collections.Generic;
    using System.Text;

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

        public double Length { get => length; private set => length = value; }
        public double Width { get => width; private set => width = value; }
        public double Height { get => height; private set => height = value; }

        public double GetSurfaceArea()
        {
            double result = 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;

            return result;

        }

        public double GetGetLateralSurface()
        {
            double result = 2 * this.Length * this.Height + 2 * this.Width * this.Height;

            return result;  
        }

        public double GetVolume()
        {
            double result = this.Length * this.Height * this.Width;

            return result;
        }


        public override string ToString()
        {
            StringBuilder message = new StringBuilder();

            message.AppendLine($"Surface Area - {this.GetSurfaceArea():f2}");
            message.AppendLine($"Lateral Surface Area - {this.GetGetLateralSurface():f2}");
            message.AppendLine($"Volume - {this.GetVolume():f2}");

            return message.ToString().TrimEnd();
        }
    }

}
