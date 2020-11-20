using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Principles_of_Programing_Assignment
{
    class Student : Person
    {
        public string student_number;
        public int age;
        public string full_name;
        public int[] scores;
        public double average_scores;
        //public string full_address;



        public Student(string First_name, string Last_name, string Student_number, int Age, int[] Scores)
        {
            first_name = First_name;
            last_name = Last_name;
            student_number = Student_number;
            age = Age;
            //full_address = Full_Address;
            scores = Scores;

            full_name = First_name + " " + Last_name;
            average_scores = Queryable.Average(Scores.AsQueryable());



        }



        /*public string ConstructFullName(string first_name, string last_name)
        {
            full_name = first_name + last_name; 
        }*/


    }
}
