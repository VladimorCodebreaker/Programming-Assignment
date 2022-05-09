using System;

namespace Assignment
{
    public class Implementation
    {
        List<Student> listOfStudents = new List<Student>();

        public Student Add()
        {
            Student student = new Student();

            Console.WriteLine("------- Create Form ------- \n" +
                "First name: ");
            student.FirstName = Console.ReadLine();

            Console.WriteLine("Last name: ");
            student.LastName = Console.ReadLine();

            Console.WriteLine("Student number: ");
            student.StudentNumber = Console.ReadLine();

            Console.WriteLine("Age: ");
            bool userInputAge = int.TryParse(Console.ReadLine(), out int age);
            student.Age = age;

            Console.Clear();

            Console.WriteLine("------- Address Section ------- \n" +
                "Country: ");
            student.Address.Country = Console.ReadLine();

            Console.WriteLine("City: ");
            student.Address.City = Console.ReadLine();

            Console.WriteLine("Street: ");
            student.Address.Street = Console.ReadLine();

            Console.WriteLine("House number / Apartment number ");
            student.Address.Adress = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("How many scores does your child have? ");
            bool userInputScores = int.TryParse(Console.ReadLine(), out int numberOfScores);

            student.Scores = new int[numberOfScores];

            Console.WriteLine("Please enter {0} amount of scores: ", numberOfScores);

            for (int i = 0; i < student.Scores.Length; i++)
            {
                bool input = int.TryParse(Console.ReadLine(), out int score);
                student.Scores[i] = score;
            }

            student.CalculateAverageScore();

            listOfStudents.Add(student);

            Console.WriteLine("===> ...You successfully added your student to the list. \n" +
                "Please press [Enter] key to continue... ====> \n");

            Console.WriteLine(student.ToString());

            Console.ReadKey();
            Console.Clear();

            return student;
        }


        public void Print()
        {
            bool isEmpty = !listOfStudents.Any();

            Console.WriteLine("------------- List of Students ------------");

            if (isEmpty)
            {
                Console.WriteLine("==> List is empty. Please add a student... ==>");
            }

            foreach (var student in listOfStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n");
        }
    }
}

