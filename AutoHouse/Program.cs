using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;


namespace AutoHouse
{
    static class Program
    {
        static void Main()
        {
            Controller test = new Controller();
            StratNewThret(test);
        }
        public static void StratNewThret(Controller test)
        {
            var currentThred = new Thread(new ThreadStart(test.Start));
            currentThred.Start();
        }
    }
}
