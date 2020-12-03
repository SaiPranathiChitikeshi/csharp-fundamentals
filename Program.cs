using System;
using System.Collections.Generic;
namespace c_
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> emplist=new List<Employee>();
            emplist.Add(new Employee() {id=1,name="prana",salary=10000,experience=6});
            emplist.Add(new Employee() {id=2,name="mary",salary=5000,experience=4});
            emplist.Add(new Employee() {id=3,name="varun",salary=20000,experience=6});
            emplist.Add(new Employee() {id=4,name="ananya",salary=8000,experience=7});
            emplist.Add(new Employee() {id=5,name="harish",salary=9000,experience=3});
            IsPromotable isPromotable=new IsPromotable(Promote);
                Employee.PromoteEmployee(emplist,isPromotable);
        }
        public static bool Promote(Employee emp){
            if(emp.experience>=5){
                return true;
            }
            else{
                return false;
            }
        }
    }
    delegate bool IsPromotable(Employee empl);
    class Employee{
        public int id {get;set;}
        public string name {get;set;}
        public int salary {get;set;}
        public int experience {get;set;}
        public static void PromoteEmployee(List<Employee> emplist, IsPromotable IsEliPromote){
            foreach(Employee emp in emplist){
                if(IsEliPromote(emp)){
                    Console.WriteLine(emp.name+" promoted");
                }
            }
        }
    }
}
