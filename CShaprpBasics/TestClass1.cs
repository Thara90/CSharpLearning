using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaprpBasics
{
    internal class TestClass1
    {

        private int i = 0;

        public void setValue(int value)
        {
            i = value;

        }
        public void getValue()
        {
            Console.WriteLine("Value of i is " + i);
        }
        //Members
        /*public void TestCase1(String result)
        {
            Console.WriteLine("Executing Testcase 1 "+ result);

        }
        public void TestCase2(String result)
        {
            Console.WriteLine("Executing Testcase 2 " + result);
        }
        */
    }
}
