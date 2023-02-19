using System.Collections;

using System.Diagnostics.SymbolStore;

namespace CShaprpBasics
{
    public class Program
    {
        static void Main(string[] args)
        {
            //NewMethod2();
        }

        private static void NewMethod2()
        {
            for (int i = 1; i <= 6; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 6; ++i)
            {
                for (int j = i; j > 0; --j)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        private static void GenericCollection() { 
        }
        private static void NonGenericCollection()
        {
            Hashtable table= new Hashtable();
            table.Add("userName", "ea");
            table.Add("password", "ea123");

            //Console.WriteLine("Username is " + table["userName"]);
            //Console.WriteLine("Username is " + table["password"]);
            foreach (var key in table.Keys)
            {
                Console.WriteLine("Value for " + key + " is " + table[key]);
            }
        }
        private static void ArrayExample()
        {
            string[] testCases = new string[] { "login", "home", "hover", "profile" };

            foreach (var testCase in testCases)
                Console.WriteLine(testCase);
        }

        private static void WhileLoopExample()
        {
            bool elementNotVisible = true;
            int noOfSeconds = 0;

            while (elementNotVisible)
            {
                Console.WriteLine("No of seconds waiting" + noOfSeconds);
                if (noOfSeconds == 4)
                    elementNotVisible = false;
                noOfSeconds++;
            }
        }

        private static void IfElseSwitchCase()
        {
            string testCaseState = "Inconclusive";
            if (testCaseState == "PASSED")
            {
                Console.WriteLine("test case is Passed");
            }
            else if (testCaseState == "Inconclusive")
            {
                Console.WriteLine("test case is Inconclusive");
            }
            else if (testCaseState == "FAILED")
            {
                Console.WriteLine("test case is Failed");
            }

            switch (testCaseState)
            {
                case "PASSED":
                    {
                        Console.WriteLine("test case is Passed");
                        break;
                    }
                case "Inconclusive":
                    {
                        Console.WriteLine("test case is Inconclusive");
                        break;
                    }
                case "FAILED":
                    {
                        Console.WriteLine("test case is Failed");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("incorrect status");
                        break;
                    }
            }
        }

        private static void NewMethod1()
        {
            TestClass2 testClass = new TestClass2();
            int result = testClass.Add(12, 8);
            Console.WriteLine(result + 10);
            testClass.Add();
        }

        private static void NewMethod()
        {
            //TestClass1 test1 = new TestClass1();
            //testCase.TestCase1("pass");
            //testCase.TestCase2("fail");
            //test1.setValue(10);
            //test1.getValue();

            //TestClass1 test2 = new TestClass1();
            //test2.setValue(15);
            //test2.getValue();

            //test1.getValue();

            //int length is 32 bydefault
            //Int32 salary = 300000;
            //Console.WriteLine(salary);

            //String name = "Thara";
            //Console.WriteLine(name.EndsWith("a"));

            //bool testCase = false;
            //Console.WriteLine(testCase);

            //Implicit Conversion
            //Int16 amount = 32000;
            //int salaryIncrement = amount;
            //salaryIncrement = 35000;
            //Console.WriteLine(salaryIncrement);

            //Explicit Conversion
            double incomeTax = 2500.90d;
            Console.WriteLine(incomeTax.GetType().Name);
            Console.WriteLine((int)incomeTax);

            //Explicit Conversion
            object loginPage = new LoginPage();
            ((LoginPage)loginPage).ClickButton();

            //Implicit Conversion using var
            var loginPage1 = new LoginPage();
            loginPage1.ClickButton();
        }
    }

    public class LoginPage{
        public String? UserName { get; set; }

        public void ClickButton() { }

    }
    public class UserListPage
    {
        public String? ListOfUsers { get; set; }
    }
}