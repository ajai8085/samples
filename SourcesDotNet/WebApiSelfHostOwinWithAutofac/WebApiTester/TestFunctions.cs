using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTester
{
    public class TestFunctions
    {
        readonly Guid _id= Guid.NewGuid();
        public void Test(string message)
        {
            Console.WriteLine("{0} with id {1} ",message,_id);
        }
    }
}
