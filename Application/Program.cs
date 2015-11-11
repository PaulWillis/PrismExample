using InputOutput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {

        static void Main(string[] args)
        {
            CalculatorReplLoop loop = new CalculatorReplLoop();
            loop.OutputService = new MessageBoxOutputService();
            loop.Run();
        }
    }
}
