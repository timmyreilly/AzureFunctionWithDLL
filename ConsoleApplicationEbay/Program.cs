using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationEbay
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //ClassLibrary1.Class1.echoID(y.First().Id.ToString()); 
            //Console.WriteLine(y.First().Name);

            ClassLibrary1.Class1.CallEbay();

            // you are going too... create a new database 
            //Model1.
            var db = new eBayFunctionTestDBEntities();
            var t = db.GetPost(1);

            var y = db.Tables.Where(x => x.Id == 2);

            //ClassLibrary1.Class1.CallEbay();

            Console.WriteLine(t.First().Name);
            Console.Read(); 
        }
    }
}
