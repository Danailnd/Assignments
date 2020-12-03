using System;
using System.Collections.Generic;
using System.Text;

namespace Principles_of_Programing_Assignment

// For instructions on how to use the CustomDataList class, type CustomDataList.Tutorial() and run in the main function. 
{
    class CustomDataList
    {
        public Dictionary<int, object[]> CustomDataDict = new Dictionary<int, object[]>();
        public int index = 0;
        public float highest_score = 0;
        public float lowest_score = 0;

        public void Add(string FirtsName,string LastName,string StudentNumber, float AverageScore)
        {
            object[] array = {FirtsName,LastName,StudentNumber,AverageScore};
            CustomDataDict.Add(index,array);
            index++;
            
            if (AverageScore>highest_score)
            {
                highest_score = AverageScore;
            }
            else if (AverageScore<lowest_score)
            {
                lowest_score = AverageScore;
            }

        }

        public object[] First()
        {
            return CustomDataDict[0];
        }
        public object[] Last()
        {
            return CustomDataDict[index];
        }
        public int Length()
        {
            return index;
        }
        public void PopulateWithSampleData()
        {
            object[] array1 = { "Danail", "Dimitrov", "1314g", 98 };
            CustomDataDict.Add(index,array1);
            index++;
            object[] array2 = { "Bob", "Jake", "66hk", 56 };
            CustomDataDict.Add(index, array2);
            index++;
            object[] array3 = { "Jill", "Jones", "4551", 78 };
            CustomDataDict.Add(index, array3);
            index++;
            object[] array4 = { "Sarah", "Connor", "gghhh", 67 };
            CustomDataDict.Add(index, array4);
            index++;
            object[] array5 = { "Bobby", "Joe", "19gh", 88 };
            CustomDataDict.Add(index, array5);
            index++;
            object[] array6 = { "Billy", "Carlson", "432", 67 };
            CustomDataDict.Add(index, array6);
            index++;
            object[] array7 = { "SomeGuy", "Generic", "11111", 11 };
            CustomDataDict.Add(index, array7);
            index++;
            object[] array8 = { "Ivan", "Atanasov", "777", 88 };
            CustomDataDict.Add(index, array8);
            index++;
        }
        public object[] GetElement(int Index)
        {
            return CustomDataDict[Index];
        }
        public void RemoveByIndex(int Index)
        {
            CustomDataDict.Remove(Index);
            while (Index+1 < index)
            {
                CustomDataDict.Add(Index, CustomDataDict[Index+1]);
                CustomDataDict.Remove(Index + 1);
                Index = Index + 1;
            }
            index = index - 1;
        }
        public void RemoveFirst()
        {
            int Index = 0;
            CustomDataDict.Remove(Index);
            while (Index + 1 < index)
            {
                CustomDataDict.Add(Index, CustomDataDict[Index + 1]);
                CustomDataDict.Remove(Index + 1);
                Index = Index + 1;
            }
            index = index - 1;
        }
        public void RemoveLast()
        {
            CustomDataDict.Remove(index);
            index = index - 1;
        }
      
        public void DisplayList()
        {
            int counter = 0;
            while (counter<index)
            {
                object[] array = CustomDataDict[counter];
                Console.WriteLine(counter + ": " + array[0] + ", " + array[1] + ", " + array[2] + ", " + array[3]);

                counter++;
            }
        }
        public object[] GetElementByName(string First_name, string Last_name)
        {
            int name_counter = 0;
            while (name_counter<index)
            {
                object[] array = CustomDataDict[name_counter];
                if(First_name == (string)array[0] && Last_name == (string)array[1])
                {
                    return (CustomDataDict[name_counter]);
                }
                else
                {
                    name_counter++;
                }
            }

            return null;

        }
        public object[] GetElementByAverage(float Average)
        {
            int name_counter = 0;
            while (name_counter < index)
            {
                object[] array = CustomDataDict[name_counter];
                if (Average == (float)array[3])
                {
                    return (CustomDataDict[name_counter]);
                }
                else
                {
                    name_counter++;
                }
            }

            return null;
        }
        public object GetElementByStudentNumber(string StudentNumber)
        {
            int name_counter = 0;
            while (name_counter < index)
            {
                object[] array = CustomDataDict[name_counter];
                if (StudentNumber == (string)array[2])
                {
                    return (CustomDataDict[name_counter]);
                }
                else
                {
                    name_counter++;
                }
            }

            return null;
        }
        public object[] GetStudentWithHighestScore()
        {
            int name_counter = 0;
            while (name_counter < index)
            {
                object[] array = CustomDataDict[name_counter];
                if (highest_score == (float)array[3])
                {
                    return (CustomDataDict[name_counter]);
                }
                else
                {
                    name_counter++;
                }
            }

            return null;
        }
        public object[] GetStudentWithLowestScore()
        {
            int name_counter = 0;
            while (name_counter < index)
            {
                object[] array = CustomDataDict[name_counter];
                if (lowest_score == (float)array[3])
                {
                    return (CustomDataDict[name_counter]);
                }
                else
                {
                    name_counter++;
                }
            }

            return null;
        }



        public static void Tutorial()
        {
            Console.WriteLine("The CustomDataList class accepts 4 elements: ");
            Console.WriteLine("First Name(string), Last Name(string), Student Number(string), AverageScore(float).");
            Console.WriteLine("When creating a new object it will automatically store the 4 four elements as");
            Console.WriteLine("Object array and index them, starting from 0.");
            Console.WriteLine("Here is a list of all methods provided by the class. ");
            Console.WriteLine("Note that all methods listed below are object methods: ");
            Console.WriteLine("1) Add(FirtsName,LastName,StudentNumber,AverageScore) - adds a new array to the object");
            Console.WriteLine(" and gives it an index of one higher than the previous highest.");
            Console.WriteLine("2) First() - returns the first element in the given object. ");
            Console.WriteLine("3) Last() - returns the last element in the given object. ");
            Console.WriteLine("4) Length() - returns the number of elements inputed in the given object.");
            Console.WriteLine("5) PopulateWithSampleData() - populates the object with 7 arrays that can be used for testing.");
            Console.WriteLine("6) GetElement(index) - returns the array that corresponds to the given index. ");
            Console.WriteLine("7) GetElementByName(first name,last name) - returns the array that corresponds to the two given names.");
            Console.WriteLine("8) GetElementByStudentNumber(student number) - returns the array that corresponds to the given student number.");
            Console.WriteLine("9) GetElementByAverage(average) - returns the array that corresponds to the given average. ");
            Console.WriteLine("10) GetStudentWithHighestScore() - returns the array with the highest average score. ");
            Console.WriteLine("11) GetStudentWithLowestScore() - returns the array with the lowest average score. ");
            Console.WriteLine("12) RemoveByIndex(Index) - removes the array that corresponds to the given index.");
            Console.WriteLine("Note that the index order will abjust accordingly to ensure that all indexes are in numerical order.");
            Console.WriteLine("13) RemoveFirst() - identical to RemoveByIndex(0). ");
            Console.WriteLine("14) RemoveLast() - removes the last element in the object.");
            Console.WriteLine("15)DisplayList() - prints out all the elements within the given object. ");
            Console.ReadLine();



        }
    }
}
