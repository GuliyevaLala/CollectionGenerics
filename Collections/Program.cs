using Domain.Models;
using System;
using System.Collections.Generic;

namespace Collections {
    class Program {
        static void Main(string[] args)
        {
            #region PreviousTask
            //DateTime startDate = DateTime.Now.AddDays(38);
            //DateTime endDate = DateTime.Now.AddDays(19);

            //double salary = 1000;

            //IEmployeeService employeeService = new EmployeeService();

            //int result = employeeService.GetFilteredEmployeeCount(startDate, endDate, salary);
            //Console.WriteLine(result);
            #endregion        }
            #region List

            //List<int> num2 = new List<int>() { 84, 12, 577, 63 };

            //List<int> num1 = new List<int>();

            //num1.Add(48);
            //num1.Add(14);
            //num1.Add(88);
            //num1.Add(47);
            //num1.Add(65);

            //num1.AddRange(2);

            //foreach (var item in num1)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = num1.BinarySearch(88);

            //Console.WriteLine(result);

            //var result = num1.FindIndex(m => m > 100);

            //var result = num1.FindLastIndex(m => m > 100);

            //var result = num1.FindLast(m => m > 100);

            //Console.WriteLine(result);

            //num1.Sort();

            //var result = num1.ToArray();

            //var result2 = result.ToList();

            //foreach (var item in num1)
            //{
            //    Console.WriteLine(item);
            //}


            //var result = num1.Contains(14);

            //Console.WriteLine(result);

            //var result = num1.Find(m => m > 50);

            //Console.WriteLine(result);

            //var result = num1.FindAll(m => m > 50);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in num1)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < num1.Count; i++)
            //{
            //    Console.WriteLine(num1[i]);
            //}

            //List<string> names = new List<string>() { "Lana", "Doe", "Nick", "Jude" };

            //var result = names.FindAll(m => m == "Lana");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var searchText = Console.ReadLine();

            //var result = Search(names, searchText);

            //if (result.Count == 0)
            //{
            //    Console.WriteLine("Oops somethin went wrong");
            //}
            //else
            //{
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Console.WriteLine(result.Count);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Person> people = new List<Person>();

            //people.Add(new Person { FullName = "Lana Del Rey", Birthday = DateTime.Now.AddDays(138), Salary = 8000 });
            //people.Add(new Person { FullName = "Sakit Ocaqli", Birthday = DateTime.Now.AddDays(-108), Salary = 500 });
            //people.Add(new Person { FullName = "Sabira Qurbanova", Birthday = DateTime.Now.AddDays(97), Salary = 1200 });

            //var result = people.FindAll(m => m.Salary > 2000);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Fullname: {item.FullName} Birthday: {item.Birthday} Salary: {item.Salary}");
            //}
            #endregion
            #region GenericnonGeneric
            //Hashtable hashtable = new Hashtable();

            //hashtable.Add(1, "Tahir");
            //hashtable.Add(2, "Eli");
            //hashtable.Add(3, "Nana");

            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //SortedList sortedList = new SortedList();

            //sortedList.Add(1, "Tahir");
            //sortedList.Add(2, "Eli");
            //sortedList.Add(3, "Nana");

            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //ArrayList arrayList = new ArrayList();

            //arrayList.Add("heey");
            //arrayList.Add(155);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedList<int, string> sortedList = new SortedList<int, string>();

            //sortedList.Add(1, "Nicat");
            //sortedList.Add(2, "Javid");
            //sortedList.Add(3, "Qoshqar");

            //foreach (KeyValuePair<int, string> item in sortedList)
            //{
            //    if (item.Key == 1)
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(5);
            //queue.Enqueue(3);
            //queue.Enqueue(7);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> stack = new Stack<int>();

            //stack.Push(11);
            //stack.Push(5);
            //stack.Push(7);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            FilteredAuthor();

        }
        #region AuthorHomework
        private static void FilteredAuthor()
        {
            List<Author> author = new List<Author>();

            author.Add(new Author { Name = "Honore", Surname = "Balzac", Age = 74 });
            author.Add(new Author { Name = "Cefer", Surname = "Cabbarli", Age = 55 });
            author.Add(new Author { Name = "Aleksey", Surname = "Tolstoy", Age = 34 });
            author.Add(new Author { Name = "Celil", Surname = "Memmedquluzade", Age = 48 });
            author.Add(new Author { Name = "Albert", Surname = "Camus", Age = 22 });

            var result = author.FindAll(m => m.Age > 40);

            foreach (var item in result)
            {
                Console.WriteLine("Name :{0} Surname :{1} Age :{2}", item.Name, item.Surname, item.Age);
            }
        }
        #endregion

    }
}
