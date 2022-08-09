using System;
using ExerciseSet.Entities;
using System.Collections.Generic;

namespace ExerciseSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Users> a = new HashSet<Users>();
            HashSet<Users> b = new HashSet<Users>();
            HashSet<Users> c = new HashSet<Users>();

            Console.Write("How many students of course A? ");
            int numA = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numA; i++)
            {
                Console.WriteLine($"Student {i} number");
                int userNumber = int.Parse(Console.ReadLine());
                Users user = new Users(userNumber);
                Course course = new Course(a, b, c, user);
                course.AddUsersA(user);               
            }
            Console.Write("How many students of course B? ");
            int numB = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numB; i++)
            {
                Console.WriteLine($"Student {i} number");
                int userNumber = int.Parse(Console.ReadLine());
                Users user = new Users(userNumber);
                Course course = new Course(a, b, c, user);
                course.AddUsersB(user);
            }
            Console.Write("How many students of course C? ");
            int numC = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numC; i++)
            {
                Console.WriteLine($"Student {i} number");
                int userNumber = int.Parse(Console.ReadLine());
                Users user = new Users(userNumber);
                Course course = new Course(a, b, c, user);
                course.AddUsersC(user);
            }
            HashSet<Users> allUsers = new HashSet<Users>();
            allUsers.UnionWith(a);
            allUsers.UnionWith(b);
            allUsers.UnionWith(c);
            Console.WriteLine("All students: " + allUsers.Count);


        }
    }
}
