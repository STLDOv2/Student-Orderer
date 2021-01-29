using System;
using System.Collections.Generic;


namespace Student_Orderer
{
    class StudentOrderer
    {
        static void Main(string[] args)
        {
            Console.Write("How many students are in your class: ");

            int numOfStudents = Convert.ToInt32(Console.ReadLine());

            string[] students = new string[numOfStudents]; 

            Console.WriteLine("\n\nPlease input the names of your students:");


            for (int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("-------------------");

            Array.Sort(students);
            for (int i = 0; i < students.Length; i++)
            {
                 Console.WriteLine(students[i]);
            }
           

            Console.ReadLine();

        }
    }
}
