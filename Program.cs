using System;
using System.Collections;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp5
{


   


    class Program
    {


        static void Main(string[] args)
        {


            var superHashTable = new SuperHashTable<Person>(100);
            var person = new Person() { Name = "Вася", Age = 25, Gender = 0 };
            superHashTable.Add(new Person() { Name = "Петя", Age = 35, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Андрей", Age = 15, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Катя", Age = 18, Gender = 1 });
            superHashTable.Add(person);

            Console.WriteLine(superHashTable.Search(new Person() { Name = "Вася", Age = 25, Gender = 0 }));
            Console.WriteLine(superHashTable.Search(person));

            Console.ReadLine();


            var hashTable = new HashTable<int, string>(100);
            hashTable.Add(5, "Привет");
            hashTable.Add(18, "Мир");
            hashTable.Add(777, "Здравствуй");
            hashTable.Add(7, "Программист");

            Console.WriteLine(hashTable.Search(6, "Вася"));
            Console.WriteLine(hashTable.Search(18, "Мир"));

            Console.ReadLine();


            var badHashTable = new BadHashTable<int>(100);
            badHashTable.Add(5);
            badHashTable.Add(18);
            badHashTable.Add(777);
            badHashTable.Add(7);

            Console.WriteLine(badHashTable.Search(6));
            Console.WriteLine(badHashTable.Search(18));



            Console.ReadLine();
        }

        //static HashTable CreateHashTable(List<Student> students)
        //{
        //    var hashTable = new HashTable();
        //    foreach (var student in students)
        //    {
        //        hashTable.Insert(student.Name, student);
        //    }
        //    return hashTable;
        //}

        //static List<Student> SearchStudentsAboveAge(List<Student> students, int ageToSearch, HashTable hashTable)
        //{
        //    var matchingStudents = new List<Student>();
        //    foreach (var student in students)
        //    {
        //        if (student.Age > ageToSearch)
        //        {
        //            var matchingStudent = hashTable.Get(student.Name);
        //            if (matchingStudent != null)
        //            {
        //                matchingStudents.Add(matchingStudent);
        //            }
        //        }
        //    }
        //    return matchingStudents;
        //}


     


        //public class HashTable
        //{
        //    private int size;
        //    public HashTable(int size)
        //    {
        //        this.size = size;
        //    }
        //    public int Hash(string key)
        //    {
        //        using (SHA256 hashAlgo = SHA256.Create())
        //        {
        //            byte[] hashBytes = hashAlgo.ComputeHash(Encoding.UTF8.GetBytes(key));
        //            string hashHex = BitConverter.ToString(hashBytes).Replace("-", "");
        //            BigInteger hashValue = BigInteger.Parse(hashHex, NumberStyles.HexNumber);
        //            return (int)(hashValue % size);
        //        }
        //    }
        //    class Student
        //    {
        //        public string Name { get; set; }
        //        public int Age { get; set; }

        //        public Student(string name, int age)
        //        {
        //            Name = name;
        //            Age = age;
        //        }
        //    }

    }
}