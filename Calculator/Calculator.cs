using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Calculator : ICalculator
    {
        public int Execute(CommandTypes commandType, Arguments args)
        {
            switch (commandType)
            {
                case CommandTypes.Add:
                    return (Add(args)); 
                case CommandTypes.Sub:
                    return (Sub(args)); 
                case CommandTypes.Mul:
                    return (Mul(args)); 
                case CommandTypes.Div:
                    return (Div(args)); 
                default:
                    throw new InvalidOperationException(); 
            }
        }
        public int Add(Arguments args)
        {
            return (args.X + args.Y);
        }

        public int Sub(Arguments args)
        {
            return (args.X - args.Y);
        }

        public int Mul(Arguments args)
        {
            return (args.X * args.Y);
        }

        public int Div(Arguments args)
        {
            return (args.X / args.Y);
        }
    }
}
