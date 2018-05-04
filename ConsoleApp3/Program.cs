using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.IO;
using System.Linq;
using System.Data;
using DAL;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Test();
            TestForDAL();
            Console.WriteLine("******************");
            //localHostTest();
            //var builder = new ConfigurationBuilder()
            //     .SetBasePath(Directory.GetCurrentDirectory())
            //     .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            //IConfigurationRoot configuration = builder.Build();
            //Console.WriteLine(configuration.GetConnectionString("user").ToString());
        }
        static void TestForDAL()
        {
            using (var db = new CADBContext())
            {
                foreach (var item in db.CaseTypes)
                {
                    Console.WriteLine($"case type is: {item.name}");
                }
            }
        }
        static void Test()
        {
            using (var db = new CADBContext())
            {
                var casetype = db.CaseTypes;
                var cases = db.Cases;
                var sequences = db.Sequences; 
                var query = from c in cases
                            join types in casetype on c.case_type_id equals types.case_type_id 
                            join seq in sequences on c.case_seq_id equals seq.case_seq_id 
                            where c.create_dt > DateTime.Parse("05/01/2018") && types.case_type_id==11 
                            select new
                            {
                                caseNum=c.case_num, typeName=types.name, seqNme=seq.name, c.create_dt
                            }
                            ;

                foreach (var item in query)
                {
                    Console.WriteLine($"case_num: {item.caseNum} --caseType: :{item.typeName} - seqName: {item.seqNme} -- {item.create_dt}");
                }
            }
        }
        static void localHostTest()
        {
            using (var db = new SakilaContext())
            {
                foreach (var item in db.actor.OrderByDescending(x=>x.actor_id).Take(10))
                {
                    Console.WriteLine($"actor: {item.first_name} {item.last_name}");
                }
            }
        }
    }
}
