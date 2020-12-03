using System;

namespace Principles_of_Programing_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //person
            Console.WriteLine("Please input your personal information. ");
            Console.Write("Input first name: ");
            string first_name = Console.ReadLine();
            Console.Write("Input last name: ");
            string last_name = Console.ReadLine();


            //student
            Console.WriteLine("Please input your student information. ");
            Console.Write("Input student number: ");
            string student_number = Console.ReadLine();
            Console.Write("Input age: ");
            int age = Convert.ToInt32(Console.ReadLine());


            //scores from student
            Console.Write("Input the number of scores you want to enter. ");
            int scores_length = Convert.ToInt32(Console.ReadLine());
            int[] scores = new int[scores_length];
            int counter = 0;
            while (counter<scores_length)
            {
                Console.Write((counter + 1) + ". Input your score: ");
                scores[counter] = Convert.ToInt32(Console.ReadLine());
                counter = counter + 1;
            }

            //address
            Console.WriteLine("Please input information about your home address. ");
            Console.Write("Input Address: ");
            string Address = Console.ReadLine();
            Console.Write("Input Street: ");
            string Street = Console.ReadLine();
            Console.Write("Input City: ");
            string City = Console.ReadLine();
            Console.Write("Input Country: ");
            string Country = Console.ReadLine();


            //creating objects
            Address address = new Address(Address,Street, City, Country);
            Student student = new Student(first_name,last_name,student_number,age,scores);


            //printing information
            Console.WriteLine("\n");
            Console.WriteLine("Student " + student.full_name +"'s average score is " + student.average_scores + ".");
            Console.WriteLine("Student " + student.full_name + " is living in " + address.city + ".");
            Console.WriteLine("Student " + student.full_name + "'s address is " + address.full_address + ".");


            Console.ReadLine();
        }
    }
}
