using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltDataStructs
{
    class DictionaryTest
    {
        public Dictionary<string, string> Test;

        public DictionaryTest()
        {
            Test = new Dictionary<string, string>();
            Test.Add("Kasper", "Meg");
            Test.Add("Terje", "Teacher");
        }

        public void TestStuff()
        {
            if (Test.ContainsKey("Kasper"))
            {
                Test.TryGetValue("Kasper", out string name);
                Console.WriteLine(name);
            }
        }

    }
}
