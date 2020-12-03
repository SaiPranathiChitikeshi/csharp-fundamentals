using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
           var marks=new[]{10,20,35.6,40.4,50};
           var l=new List<double>() {10,20,30,40,50};
           double r=0;
           foreach(double n in l){
               r+=n;
           }
           double a=r/l.Count;
           Console.WriteLine(a);
        }
    }
}
