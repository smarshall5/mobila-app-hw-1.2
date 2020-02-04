using mobila_app_hw_1._2.Models;
using System;
using System.Collections.Generic;

namespace mobila_app_hw_1._2
{
    class Program
    {
         private static List<Student> Students = new List<Student>();
        private static List<Teacher> Teachers = new List<Teacher>();
        private static int userInput;
        private static int secondUserInput;

        static void Main(string[] args)
        {
            do {
                Console.Write("1) Add Student\n" +
                            "2) Add Teacher\n" +
                            "3)View Teachers and Students\n" +
                            "4) End\n==");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    Random rnd = new Random();
                  //  int academiaChoice;

                    Student student = new Student();
                    Console.WriteLine("Enter the Student's Name");
                    student.Name = Console.ReadLine();
                    Console.WriteLine("Enter the Students Age");
                    student.Age = Convert.ToInt32(Console.ReadLine());
                    student.Id = rnd.Next(1, 5000);
                    Console.WriteLine("Enter The Field of Study");
                    Console.WriteLine("1)ComputerScience 2)Biology 3) Engineering 4) Chemistry 5)Physics 6)Botany");
                    student.Academia = (Academic)Enum.ToObject(typeof(Academic), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Enter amount of Credits Earned to Date");
                    student.Credits= Convert.ToInt32(Console.ReadLine());
                    student.StudentTeacherIdentifier = 1;
                    Students.Add(student);


                }
                if (userInput == 2) {
                    Random rnd = new Random();

                    Teacher teacher = new Teacher();
                    Console.WriteLine("Enter the Teachers Name");
                    teacher.Name = Console.ReadLine();
                    Console.WriteLine("Enter the Teacher Age");
                    teacher.Age= Convert.ToInt32(Console.ReadLine());
                    teacher.Id = rnd.Next(5000, 5500);
                    Console.WriteLine("Enter Area of Expertise");
                    Console.WriteLine("1)ComputerScience 2)Biology 3) Engineering 4) Chemistry 5)Physics 6)Botany");
                    teacher.Academia = (Academic)Enum.ToObject(typeof(Academic), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("How many Years of Service?");
                    teacher.YearsOfService = Convert.ToInt32(Console.ReadLine());
                    teacher.StudentTeacherIdentifier = 2;
                    Teachers.Add(teacher);

                }
                if (userInput == 3) {
                    do {
                        Console.Write("1)Students\n" + "2)Teachers\n" + "3)return");
                        secondUserInput = Convert.ToInt32(Console.ReadLine());
                        if (secondUserInput == 1)
                        {
                            foreach(var p in Students)
                            {
                                
                                    Console.WriteLine("Name: " + p.Name +" Age: " + p.Age + " id: " + p.Id + " Field:" + p.Academia + " Credits Earned:" + p.Credits);
                                
                               
                            }

                        }

                        if (secondUserInput == 2) {

                            foreach (var p in Teachers)
                            {

                                Console.WriteLine("Name: " + p.Name + " Age: " + p.Age + " id: " + p.Id + " Field:" + p.Academia + " Years of Service:" + p.YearsOfService);


                            }

                        }
                    } 
                    
                    
                    while (secondUserInput!=3);

                }


            }
            while(userInput!=4);

            
    }
    }
}
