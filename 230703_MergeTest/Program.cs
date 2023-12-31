﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230703_MergeTest
{
   
        public class Ruler
        {
            // 2023. 07. 03. Modified class position / Alpha
            private const float ONE_INCH = 2.54F;
            public int Centimeter { get; set; } = 0;
            public float Inch
            {
                get { return Centimeter * ONE_INCH; }
                private set { Centimeter = (int)(value / ONE_INCH); }
            }

            public Ruler(int cmValue) { Centimeter = cmValue; }
            public void Run()
            {
                Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다 ");
            }

        }
        // 2023. 07. 03. Modified class position / Alpha

        internal class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Hello World!");
                Ruler ruler = new Ruler(10);
                ruler.Run();

            }

        }

 
}
