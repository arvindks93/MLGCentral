using DAL;
using System;
using System.Linq;
namespace BAL
{
    public class TestBAL
    {
        private string _case_num;
        private string _case_type;
        private DateTime _case_create_dt;

        public TestBAL()
        {
            using (var db=new CADBContext())
            {
                //var c = db.Cases.OrderByDescending(x=> x.create_dt>DateTime.Parse("05/01/2018") && x.case_type_id==6).ToList() ;                        
                foreach (var item  in db.CaseTypes)
                {
                    Console.WriteLine($"case type:{item.case_type_id} and name:{item.name}");
                }
            }
        }
        public void TestBALForData()
        {

        }

    }
    public class BALTesAClass
    {
        public string BALReturn()
        {
            return "Hello I am BAL";
        }
    }
}
