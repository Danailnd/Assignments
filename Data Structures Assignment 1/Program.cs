using System;
using System.Collections.Generic;


namespace Data_Structures_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            int counter = 0;
            bool forever = true;
            bool first_time = true;

            Dictionary<int, CustomDataList> CustomDataDict = new Dictionary<int, CustomDataList>();


            //main menu setup
            //note that you can manually use the custom data structure by using the class CustomDataList
            while (forever)
            {
                Console.WriteLine("1. Input new element to the data structure. ");
                Console.WriteLine("2. Access elements from the data structure. ");
                Console.WriteLine("3. Use methods associated with CustomDataList class. ");
                Console.WriteLine("4. Exit.\n ");
                Console.Write("Input the number corresponding to the desired operation: ");
                int response = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (response)
                {

                    //input elements
                    case 1:
                        CustomDataDict.Add(counter, Accept_Input(counter));
                        counter = counter + 1;
                        first_time = false;
                        break;

                    //show elements
                    case 2:
                        if (first_time)
                        {
                            Console.WriteLine("PLease populate your data structure first");
                        }
                        else
                        {
                            Console.WriteLine("1. Access specific element using its index. ");
                            Console.WriteLine("2. View all elements in the data structure. ");
                            Console.WriteLine("Input the number corresponding to the desired operation. ");
                            Console.WriteLine("Press any other number to return to the main menu. ");
                            int access_response = Convert.ToInt32(Console.ReadLine());

                            switch (access_response)
                            {

                                //show specific element
                                case 1:
                                    Console.Write("Input index (note that indexing begins with 0): ");
                                    int index = Convert.ToInt32(Console.ReadLine());
                                    CustomDataList access_object = CustomDataDict[index];
                                    Console.WriteLine();
                                    Console.WriteLine("Fist name: " + access_object.firstName);
                                    Console.WriteLine("Last name: " + access_object.lastName);
                                    Console.WriteLine("Student number: " + access_object.studentNumber);
                                    Console.WriteLine("Average Score: " + access_object.averageScore);

                                    break;
                               
                                //show all elements 
                                case 2:

                                    int show_counter = 0;
                                    while (show_counter < counter)
                                    {
                                        Console.Write("Index: " + show_counter);

                                        CustomDataList show_object = CustomDataDict[show_counter];

                                        Console.WriteLine(" - Content: " + show_object.firstName + " , " + show_object.lastName + " , " + show_object.studentNumber + " , " + show_object.averageScore);

                                        show_counter = show_counter + 1;
                                    }
                                    break;

                                //return to main menu
                                default:
                                    break;
                            }
                        }
                        break;

                    //use class methods
                    case 3:
                        Console.WriteLine("1. View list of all available methods. ");
                        Console.WriteLine("2. Execute specific method. ");
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Please input integer between 1 and 4");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Press any key to return to the main menu. ");
                Console.ReadLine();
                Console.Clear();
            }



            static CustomDataList Accept_Input(int index)
            {

                //accept input
                Console.Write("Input student first name:");
                string first_name = Console.ReadLine();
                Console.Write("Input student last name:");
                string last_name = Console.ReadLine();
                Console.Write("Input student number:");
                string student_number = Console.ReadLine();
                Console.Write("Input student average score:");
                double average_score = Convert.ToDouble(Console.ReadLine());


                //creating object
                CustomDataList object1 = new CustomDataList(index,first_name, last_name, student_number, average_score);
                return (object1);
            }
 



            
        }
    }
}
