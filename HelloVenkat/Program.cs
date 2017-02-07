using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloVenkat
{
   public class Student
    {
        string Firstname;
        string LastName;
        static int Count=1;

        static Student()
        {
            Count++;
        }
        public static int TotalCount()
        {
            return Count;
         }
        public Student(string Firstname, string LastName)
        {
            this.Firstname = Firstname;
            this.LastName = LastName;
        }
        public void FullName()
        {
            Console.WriteLine("The Fullname is " + Firstname + " " + LastName);
        }
    }
     class Program
    {
         static void Main()
        {
            Student s1 = new Student("Venu", "Reddy");
            Student s2 = new Student("Madhav", "Challa");
            s1.FullName();
            s2.FullName();
            int Result = Student.TotalCount();
            Console.WriteLine("The ToatlCount is "+ Result);
            Console.ReadLine();
        }
    }
 }
            
          
            
   
            
        
         



            

            
           
            
    









