using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroTouchNode
{
    /// <summary>
    /// Wrapper class for my first node
    /// </summary>
    public class MyFirstNode
    {
        // This hides the overall class as a node
        private MyFirstNode() { }

        /// <summary>
        /// This is my first node that outputs a string that says Hello world. Awesome.
        /// </summary>
        /// <param name="extraMessage">Optional extra message from Dynamo.</param>
        /// <returns name="helloWorldString">Our hello world node.</returns>
        public static string HelloWorld(string extraMessage = "")
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //returns one output of hello world
            return $"Hello, {userName}. {extraMessage}";
        }
    }
}
