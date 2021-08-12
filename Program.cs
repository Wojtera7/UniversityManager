using System;

namespace UniversityManager
{
    class Program
    {
        static void Main(string[] args)
        {

            UniversityManager universityManager = new UniversityManager();

            universityManager.MaleStudents();

            universityManager.SortStudentsByAge();

            universityManager.StudentsFromTech();

            universityManager.Something();


            Console.WriteLine("Select University Id");

            int select = Convert.ToInt32(Console.ReadLine());

            universityManager.StudentsFromSelectedUniversity(select);









            Console.WriteLine("The end");
            Console.ReadKey();


        }
    }
}
