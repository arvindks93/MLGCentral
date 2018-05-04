using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Test();
        }
        static void Test()
        {
            using (var db = new BloggingContext())
            {
                //db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                //var count = db.SaveChanges();
                //Console.WriteLine($"{count} records saved to database");
                //Console.WriteLine();
                //Console.WriteLine("All blogs in the database");
                foreach(var blogs in db.Blogs)
                {
                    Console.WriteLine($" - {blogs.Url}");
                }
            }
        }
    }
}
