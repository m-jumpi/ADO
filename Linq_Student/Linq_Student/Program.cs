using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> studentQuery =
                from student in students where student.Scores[0] > 90 && student.Scores[3] < 80
                //orderby student.Last ascending
                orderby student.Scores[0] descending
                select student;

            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1}, {2}", student.First, student.Last, student.Scores[0]);
            }

            var studentQuery2 =
                from student in students
                group student by student.Last[0];

            foreach (var studentGroup in studentQuery2)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (Student student in studentGroup)
                {
                    Console.WriteLine("     {0}, {1}", student.Last, student.First);
                }
            }

            var studentQuery3 =
                from student in students
                group student by student.Last[0];

            foreach (var studentGroup in studentQuery3)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (var student in studentGroup)
                {
                    Console.WriteLine("     {0}, {1}", student.Last, student.First);
                }
            }

            var studentQuery4 =
                from student in students
                group student by student.Last[0] into studentGroup
                orderby studentGroup.Key
                select studentGroup;

            foreach (var studentGroup in studentQuery4)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (var student in studentGroup)
                {
                    Console.WriteLine("     {0}, {1}", student.Last, student.First);

                }
            }

            var studentQuery5 =
                from student in students
                let toralScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                where toralScore / 4 < student.Scores[0]
                select student.Last + " " + student.First;

            Console.WriteLine("studentQuery5");
            foreach (string s in studentQuery5)
            {
                Console.WriteLine(s);
            }

            var studentQuery6 =
                from student in students
                let toralScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                select toralScore;

            double averageScore = studentQuery6.Average();
            Console.WriteLine("Class average score is {0}", averageScore);

            IEnumerable<string> studentQuery7 =
                from student in students
                where student.Last == "Garcia"
                select student.First;

            Console.WriteLine("The Garcias in the class are:");
            foreach (var s in studentQuery7)
            {
                Console.WriteLine(s);
            }

            var studentQuery8 =
                from student in students
                let x = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                where x > averageScore
                select new { id = student.Id, score = x, name=student.First };

            foreach (var item in studentQuery8)
            {
                Console.WriteLine("StudentID: {0}, Score: {1}, Name: {2}", item.id, item.score, item.name);
            }

            Console.ReadKey();
        }

        public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int Id { get; set; }
            public List<int> Scores;
        }

        static List<Student> students = new List<Student>
        {
            new Student { First="Svetlana", Last="Omelchenko", Id=111, Scores= new List<int> {97, 92, 81, 60}},
            new Student { First="Claire", Last="O’Donnell", Id=112, Scores= new List<int> {75, 84, 91, 39}},
            new Student { First="Name", Last="O’Last", Id=113, Scores= new List<int> {95, 84, 91, 39}},
            new Student { First="Name", Last="K’Last", Id=114, Scores= new List<int> {95, 84, 91, 39}},
            new Student { First="GName1", Last="Garcia", Id=115, Scores= new List<int> {97, 92, 81, 60}},
            new Student { First="GName2", Last="Garcia", Id=116, Scores= new List<int> {95, 84, 91, 39}}
        };
    }
}
