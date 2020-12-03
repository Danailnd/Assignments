using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_Assignment_1
{
    class CustomDataList
    {

        public string firstName;
        public string lastName;
        public string studentNumber;
        public double averageScore;
        public int index;

        readonly int length = 0;

        public CustomDataList(int Index,string FirstName, string LastName, string StudentNumber,double AverageScore)
        {
            firstName = FirstName;
            lastName = LastName;
            studentNumber = StudentNumber;
            averageScore = AverageScore;
            index = Index;
            
            length = length ++;

        }
    }
}
