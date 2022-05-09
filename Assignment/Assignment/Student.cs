using System;

namespace Assignment
{
    public class Student : Person
    {
        // Properties
        public string StudentNumber { get; set; }
        public int Age { get; set; }
        public int[] Scores { get; set; }
        public decimal AverageScore { get; set; }
        public Address Address { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public string FullAddress => $"{Address.Country}, {Address.City}, {Address.Street}, {Address.Adress}";

        public Student()
        {
            Address = new Address();
        }

        // Methods
        public void CalculateAverageScore()
        {
            int sum = 0;

            if (Scores.Length == 0)
            {
                throw new DivideByZeroException("==> Please try again, adding some scores... ==>");
            }

            for (int i = 0; i < Scores.Length; i++)
            {
                sum += Scores[i];
            }

            this.AverageScore = (decimal)sum / Scores.Length;
        }

        public override string ToString()
        {
            return $"-------- Information about student: ---->  [ {FullName} ] \n" +
                $"Average score: {AverageScore} \n" +
                $"City: {Address.City} \n" +
                $"Full address: {FullAddress} \n" +
                $"Age: {Age} \n" +
                $"Student number: {StudentNumber} \n";
        }
    }
}

