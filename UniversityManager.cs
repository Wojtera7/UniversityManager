using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManager
{
    class UniversityManager
    {

        List<University> universities;
        List<Student> students;


        public UniversityManager()
        {

            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Techy" });

            students.Add(new Student { Id = 1, Name = "Carl", Gender = "M", Age = 10, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Tony", Gender = "M", Age = 13, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Leia", Gender = "F", Age = 17, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "JJ", Gender = "F", Age = 21, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Johny", Gender = "M", Age = 27, UniversityId = 2 });


        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from workVariable in students where workVariable.Gender == "M" select workVariable;

            Console.WriteLine("Male students");

            foreach (Student workVariable in maleStudents)
            {

                workVariable.Print();
                
            }


        }


        public void SortStudentsByAge()
        {

            var sortedStudents = from work in students orderby work.Age select work;

            Console.WriteLine("Students sorted by age");

            foreach (Student work in sortedStudents)
            {

                work.Print();


            }



        }

        public void StudentsFromTech()
        {

            IEnumerable<Student> techyStudents = from work1 in students join work2 in universities on work1.UniversityId equals work2.Id where work2.Name == "Techy" select work1;

            Console.WriteLine("Students form Techy");
            foreach (Student work in techyStudents)
            {

                work.Print();

            }



        }





        public void StudentsFromSelectedUniversity(int Id)
        {

            IEnumerable<Student> selectedStudents = from work1 in students 
                                                join work2 in universities on work1.UniversityId equals work2.Id 
                                                where work2.Id == Id
                                                select work1;

            Console.WriteLine("Students form {0}", Id);
            foreach (Student work in selectedStudents)
            {

                work.Print();

            }



        }



        public void Something()
        {

            var newCollection = from work1 in students
                                join work2 in universities on work1.UniversityId equals work2.Id
                                orderby work1.Name
                                select new { StudentName = work1.Name, UniversityName = work2.Name };


            Console.WriteLine("New Collection");

            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1} ", col.StudentName, col.UniversityName);
            }


        }









    }
}
