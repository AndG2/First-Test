using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_20
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isTesting = true;


            while (isTesting == true)
            {


                //git commt testing words
                // just adding this here to test stuff

                Console.Write("which question would you like to see? :");


                try
                {
                int question = Convert.ToInt32(Console.ReadLine());
                    switch (question)
                    {
                        case 1:
                            Quest1a();
                            return;
                        case 2:
                            Quest1bc();
                            return;
                        case 3:
                            Quest1d();
                            return;
                        case 4:
                            return;

                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }

                //not getting to here :/
                Console.Write("Would you like to look at another question? (Y/N):");
                char repeat = Convert.ToChar(Console.ReadLine());

                try
                {
                    if (repeat == 'y' || repeat == 'Y')
                    {
                        isTesting = true;
                    }
                    else if (repeat == 'n' || repeat == 'N')
                    {
                        isTesting = false;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }

        }


        public static void Quest1a()
        {
            Console.Write("How many students are in the class? :");
            int studentsInClass = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            string studentName = "";
            Queue<string> studentList = new Queue<string>();
            while (count < studentsInClass)
            {
                Console.Write($"What is the name of student #{count + 1}? : ");
                studentName = Console.ReadLine();
                studentList.Enqueue(studentName);
                count++;
                studentName = "";
            }

            foreach (var stud in studentList)
            {
                Console.WriteLine(stud);
            }

            Console.ReadLine();
        }

        public static void Quest1bc()
        {
            Console.Write("How many students are in the class? :");
            int studentsInClass = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            string studentName = "";
            List<string> studentList = new List<string>();
            while (count < studentsInClass)
            {
                Console.Write($"What is the name of student #{count + 1}? : ");
                studentName = Console.ReadLine();
                studentList.Add(studentName);
                count++;
                studentName = "";
            }

            studentList.Sort((x,y)=> string.Compare(x, y));
            Console.WriteLine("The list is now sorted by name alphabetically.");

            foreach (var stud in studentList)
            {
                Console.WriteLine(stud);
            }

            Console.ReadLine();
        }

        public static void Quest1d()
        {
            string studentName = "";
            int count = 0;
            List<string> studentList = new List<string>();
            do
            {
                Console.Write($"What is the name of student #{count + 1}? : ");
                studentName = Console.ReadLine();
                studentList.Add(studentName);
                count++;
            } while (studentName != "");

            studentList.Sort((x, y) => string.Compare(x, y));
            Console.WriteLine("The list is now sorted by name alphabetically.");

            foreach (var stud in studentList)
            {
                Console.WriteLine(stud);
            }

            Console.ReadLine();
        }

        public static void Quest2a()
        {
            Dictionary<int, string> studentDatabase = new Dictionary<int, string>();
            studentDatabase.Add(101, "Tommy");
            studentDatabase.Add(102, "Jake");
            studentDatabase.Add(103, "Nathan");
            studentDatabase.Add(104, "Andrew");
            studentDatabase.Add(105, "David");
            studentDatabase.Add(106, "Michael");
            studentDatabase.Add(107, "Tommy Jr.");

            var minimumId = studentDatabase.Keys.Min();
            var maximumId = studentDatabase.Keys.Max();

            Console.WriteLine($"input student id. valid values are {minimumId}-{maximumId}.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            string studentName;
            if (studentDatabase.TryGetValue(userInput, out studentName))
            {
                Console.WriteLine($"ID: {userInput}- Name: {studentName}");
            }
            else
            {
                throw new Exception("That is not a valid student ID number.");
            }

        }
    }
}
