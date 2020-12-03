using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
           var book=new Book("pranathi's grade book");
           book.AddGrade(90);
           book.AddGrade(60);
           book.AddGrade(80);
           book.GetStatistics();
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
