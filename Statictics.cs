using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Statictics
    {
        public double Average;
           
        public double High;
        public double Low;
        public char Letter;
            
        public double Sum;
        public int Count;
        public void Add(double number){
            Sum+=number;
            Count+=1;
            Low=Math.Min(number,Low);
            High=Math.Max(number,High);
        }

        public Statictics()
        {
               Average=0.0; 
                Count=0;
                Sum=0.0;
                High=double.MinValue;
                Low=double.MaxValue;
        }
    }
}