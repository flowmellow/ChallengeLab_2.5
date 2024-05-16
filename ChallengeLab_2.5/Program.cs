/*
Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division. You may create a structure for the student.
Test Data :
Input the Roll Number of the student :784
Input the Name of the Student :James
Input the marks of Physics, Chemistry and Computer Application : 70 80 90
Expected Output :
Roll No : 784
Name of Student : James
Marks in Physics : 70
Marks in Chemistry : 80
Marks in Computer Application : 90
Total Marks = 240
Percentage = 80.00
Division = First
*/

using System.Threading.Channels;

namespace ChallengeLab_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentData student = new StudentData();
            Console.WriteLine("Enter student roll number: ");
            student.RollNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name: ");
            student.StudentName = Console.ReadLine();
            Console.WriteLine("Enter Physics grade: ");
            student.PhysicsGrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Chemistry grade: ");
            student.ChemistryGrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Computer Application grade: ");
            student.CompAppGrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("----------- Formatted Student Data-------------");
            StudentData studentData = new StudentData();
            studentData.PrintData(student.RollNumber, student.StudentName, student.PhysicsGrade, student.ChemistryGrade, student.CompAppGrade);
            Math math = new Math();
            math.Grades(student.PhysicsGrade, student.ChemistryGrade, student.CompAppGrade);
            Console.WriteLine("Division = First");


        }
        public class StudentData
        {
            public int RollNumber { get; set; }
            public string StudentName { get; set; }
            public double PhysicsGrade { get; set; }
            public double ChemistryGrade { get; set; }
            public double CompAppGrade { get; set; }

            public void PrintData(int rollNumber, string studentName, double physicsGrade, double chemistryGrade, double compAppGrade)
            {
                Console.WriteLine($"Roll No : {rollNumber}");
                Console.WriteLine($"Name of Student: {studentName}");
                Console.WriteLine($"Marks in Physics: {physicsGrade}");
                Console.WriteLine($"Marks in Chemistry: {chemistryGrade}");
                Console.WriteLine($"Marks in Computer Application: {compAppGrade}");
            }

        }
        public class Math 
        {
            public void Grades(double physicsGrade, double chemistryGrade, double compAppGrade )
            {
                double totalMarks = (physicsGrade + chemistryGrade + compAppGrade);
                double divideMarks = totalMarks / 3;

                Console.WriteLine($"Total Marks = {totalMarks}");
                Console.WriteLine($"Percentage: {divideMarks}");

                
            }

        }



    }
}
