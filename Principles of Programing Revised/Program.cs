using System;
using System.Collections.Generic;

namespace Principles_of_Programing_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // For instructions on how to use the CustomDataList class, type CustomDataList.Tutorial() and run. 
            Assignment2_UserInterface();
            Console.ReadLine();
        }
        static void Assignment2_UserInterface()
        {
            //setup
            int counter = 0;
            bool forever = true;
            bool first_time = true;
            bool forever_access = true;
            CustomDataList obj = new CustomDataList();

            //main menu setup
            while (forever)
            {
                Console.WriteLine("1. Input new element to the data structure. ");
                Console.WriteLine("2. Access and sort elements from the data structure. ");
                Console.WriteLine("3. Generate sample data for testing. ");
                Console.WriteLine("4. Exit.\n ");
                Console.Write("Input the number corresponding to the desired operation: ");
                int response = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (response)
                {

                    //input elements
                    case 1:
                        Console.Write("Input student first name:");
                        string first_name = Console.ReadLine();
                        Console.Write("Input student last name:");
                        string last_name = Console.ReadLine();
                        Console.Write("Input student number:");
                        string student_number = Console.ReadLine();
                        Console.Write("Input student average score:");
                        float average_score = (float)Convert.ToDouble(Console.ReadLine());
                        
                        obj.Add(first_name,last_name,student_number,average_score);
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
                            while (forever_access) 
                            {
                                
                                Console.WriteLine("1. Access specific element using its index. ");
                                Console.WriteLine("2. View all elements ordered in acsending index order. (use -2 for descending).");
                                Console.WriteLine("3. View all elements in ascending alphabetical order. (use -3 for descending)");
                                Console.WriteLine("4. View all elements in ascending average score order. (use -4 for descending)");
                                /*Note that the feature "view all element by ascending student number" was not implement because
                                 It gives no valuable information. In the case that this function becomes neccessary the alphabetical
                                order funciton can easily be used as a template. */  
                                Console.WriteLine("Input the number corresponding to the desired operation. ");
                                Console.WriteLine("Press any other number to return to the main menu. ");
                                int access_response = Convert.ToInt32(Console.ReadLine());

                                switch (access_response)
                                {

                                    //show specific element
                                    case 1:
                                        Console.Write("Input index (note that indexing begins with 0): ");
                                        int index = Convert.ToInt32(Console.ReadLine());
                                        object[] array = obj.GetElement(index);
                                        Console.WriteLine();
                                        Console.WriteLine("Fist name: " + array[0]);
                                        Console.WriteLine("Last name: " + array[1]);
                                        Console.WriteLine("Student number: " + array[2]);
                                        Console.WriteLine("Average Score: " + array[3]);

                                        break;

                                    
                                    //by index
                                    case 2:
                                        int show_counter = 0;
                                        while (show_counter < obj.Length())
                                        {

                                            object[] index_show_array = obj.GetElement(show_counter);

                                            Console.WriteLine(show_counter + " - " + index_show_array[0] + ", " + index_show_array[1] + ", " + index_show_array[2] + ", " + index_show_array[3]);

                                            show_counter ++;
                                        }
                                        break;
                                    case -2:
                                        show_counter = obj.Length();
                                        while (show_counter < counter)
                                        {
                                            Console.Write(show_counter);

                                            object[] index_show_array = obj.GetElement(show_counter);

                                            Console.WriteLine();
                                            Console.WriteLine(" - " + index_show_array[0] + ", " + index_show_array[1] + ", " + index_show_array[2] + ", " + index_show_array[3]);

                                            show_counter ++;
                                        }
                                        break;

                                    //by name
                                    case 3:
                                        show_counter = 1;
                                        int compare_counter = 0;
                                        int current_max = 0;
                                        int arrange_counter;
                                        
                                        bool looking_for_my_place = true;
                                        string[] alphabetical_array = new string[obj.Length()];
                                        array = obj.GetElement(0);

                                        first_name = (string)array[0];
                                        last_name = (string)array[1];
                                        string full_name = (string)array[0] + " " + (string)array[1];
                                        alphabetical_array[0] = full_name;

                                        
                                        while (show_counter < obj.Length())
                                        {
                                            array = obj.GetElement(show_counter);
                                            first_name = (string)array[0];
                                            last_name = (string)array[1];
                                            full_name = (string)array[0] + " " + (string)array[1];
                                            alphabetical_array[show_counter] = full_name;
                                            looking_for_my_place = true;
                                            compare_counter = 0;
                                            while (looking_for_my_place)
                                            {
                                                switch (String.Compare(alphabetical_array[compare_counter],full_name))
                                                {
                                                    //the word in question is closer to begining of the alphabet 
                                                    case 1:

                                                        arrange_counter = current_max;

                                                        while (arrange_counter>=compare_counter)
                                                        {
                                                            alphabetical_array[arrange_counter + 1] = alphabetical_array[arrange_counter];

                                                            arrange_counter--;
                                                        }
                                                        alphabetical_array[compare_counter] = full_name;

                                                        current_max++;
                                                        looking_for_my_place = false;
                                                        break;
                                                    //the word is not closer to the begining of the alphabet
                                                    case -1:

                                                        if (compare_counter==current_max)
                                                        {
                                                            alphabetical_array[compare_counter+1] = full_name;
                                                            current_max++;
                                                            looking_for_my_place = false;
                                                        }
                                                        break;
                                                    //the two words are identical
                                                    case 0:
                                                        arrange_counter = current_max;

                                                        while (arrange_counter >= compare_counter)
                                                        {
                                                            alphabetical_array[arrange_counter + 1] = alphabetical_array[arrange_counter];

                                                            arrange_counter--;
                                                        }
                                                        alphabetical_array[compare_counter] = full_name;

                                                        current_max++;
                                                        looking_for_my_place = false;
                                                        break;
                                                }
                                                compare_counter++;
                                            }
                                            show_counter++;
                                           
                                        }

                                        //to print
                                        Console.WriteLine();
                                        foreach (string name in alphabetical_array)
                                        {
                                            string[] temporary_name_array = new string[2];
                                            temporary_name_array = name.Split(" ");
                                            array = obj.GetElementByName(temporary_name_array[0], temporary_name_array[1]);
                                           
                                            Console.WriteLine(array[0] + ", " + array[1] + ", " + array[2] + ", " + array[3]);
                                        }

                                        break;
                                    
                                    //by name reverse
                                    case -3:
                                        show_counter = 1;
                                        compare_counter = 0;
                                        current_max = 0;
                                        

                                        looking_for_my_place = true;
                                        alphabetical_array = new string[obj.Length()];
                                        array = obj.GetElement(0);

                                        first_name = (string)array[0];
                                        last_name = (string)array[1];
                                        full_name = (string)array[0] + " " + (string)array[1];
                                        alphabetical_array[0] = full_name;


                                        while (show_counter < obj.Length())
                                        {
                                            array = obj.GetElement(show_counter);
                                            first_name = (string)array[0];
                                            last_name = (string)array[1];
                                            full_name = (string)array[0] + " " + (string)array[1];
                                            alphabetical_array[show_counter] = full_name;
                                            looking_for_my_place = true;
                                            compare_counter = 0;
                                            while (looking_for_my_place)
                                            {
                                                switch (String.Compare(full_name, alphabetical_array[compare_counter]))
                                                {
                                                    case 1:

                                                        arrange_counter = current_max;

                                                        while (arrange_counter >= compare_counter)
                                                        {
                                                            alphabetical_array[arrange_counter + 1] = alphabetical_array[arrange_counter];

                                                            arrange_counter--;
                                                        }
                                                        alphabetical_array[compare_counter] = full_name;

                                                        current_max++;
                                                        looking_for_my_place = false;
                                                        break;
                                                    case -1:

                                                        if (compare_counter == current_max)
                                                        {
                                                            alphabetical_array[compare_counter + 1] = full_name;
                                                            current_max++;
                                                            looking_for_my_place = false;
                                                        }
                                                        break;
                                                    //the two words are identical
                                                    case 0:
                                                        arrange_counter = current_max;

                                                        while (arrange_counter >= compare_counter)
                                                        {
                                                            alphabetical_array[arrange_counter + 1] = alphabetical_array[arrange_counter];

                                                            arrange_counter--;
                                                        }
                                                        alphabetical_array[compare_counter] = full_name;

                                                        current_max++;
                                                        looking_for_my_place = false;
                                                        break;
                                                }
                                                compare_counter++;
                                            }
                                            show_counter++;

                                        }

                                        //to print
                                        Console.WriteLine();
                                        foreach (string name in alphabetical_array)
                                        {
                                            string[] temporary_name_array = new string[2];
                                            temporary_name_array = name.Split(" ");
                                            array = obj.GetElementByName(temporary_name_array[0], temporary_name_array[1]);

                                            Console.WriteLine(array[0] + ", " + array[1] + ", " + array[2] + ", " + array[3]);
                                        }

                                        break;
                                    
                                    //by average
                                    case 4:

                                        show_counter = 1;
                                        compare_counter = 0;
                                        current_max = 0;
                                        float average;
                                        

                                        looking_for_my_place = true;
                                        float[] average_array = new float [obj.Length()];
                                        array = obj.GetElement(0);
                                        Console.WriteLine(array[3]);
                                        average = (int)array[3];
                                        average_array[0] = average;

                                        while (show_counter < obj.Length())
                                        {
                                            array = obj.GetElement(show_counter);
                                            average = (float)array[3];
                                            average_array[show_counter] = average;
                                            looking_for_my_place = true;
                                            compare_counter = 0;
                                            while (looking_for_my_place)
                                            {
                                                if ((float)array[3]>average_array[compare_counter])
                                                {
                                                    arrange_counter = current_max;

                                                    while (arrange_counter >= compare_counter)
                                                    {
                                                        average_array[arrange_counter + 1] = average_array[arrange_counter];

                                                        arrange_counter--;
                                                    }
                                                    average_array[compare_counter] = average;

                                                    current_max++;
                                                    looking_for_my_place = false;
                                                }
                                                else if ((float)array[3]<average_array[compare_counter])
                                                {
                                                    if (compare_counter == current_max)
                                                    {
                                                        average_array[compare_counter + 1] = average;
                                                        current_max++;
                                                        looking_for_my_place = false;
                                                    }
                                                    
                                                }
                                                else
                                                {
                                                    arrange_counter = current_max;

                                                    while (arrange_counter >= compare_counter)
                                                    {
                                                        average_array[arrange_counter + 1] = average_array[arrange_counter];

                                                        arrange_counter--;
                                                    }
                                                    average_array[compare_counter] = average;

                                                    current_max++;
                                                    looking_for_my_place = false;
                                                }
                                                compare_counter++;
                                            }
                                            show_counter++;

                                        }

                                        //to print
                                        Console.WriteLine();
                                        foreach (float n in average_array)
                                        {
                                            array = obj.GetElementByAverage(n);

                                            Console.WriteLine(array[0] + ", " + array[1] + ", " + array[2] + ", " + array[3]);
                                        }

                                        break;




                                    //return to main menu
                                    default:
                                        forever_access = false;
                                        break;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        break;

                    
                    case 3:

                        obj.PopulateWithSampleData();
                        first_time = false;
                        Console.WriteLine("Done! 8 data elements have been added. ");
                        break;

                    //exit
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

        }

    }
}
