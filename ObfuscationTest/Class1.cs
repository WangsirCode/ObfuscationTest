using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObfuscationTest
{
    public class ObfuscationTest
    {
        int number = 1;
        string key = "public key"; 
        private void encoding()
        {
            key = "encoding";
        }

        public void decoing()
        {
            key = "decoding";
        }

    }

    class PrivateTest
    {
        public void testFunc()
        {
            string testString = "testString";
        }
    }
}
