using System;
namespace Calculator
{
    public interface ICalculator
    {
        int Add(Application.Arguments args);
        int Div(Application.Arguments args);
        int Execute(Application.CommandTypes commandType, Application.Arguments args);
        int Mul(Application.Arguments args);
        int Sub(Application.Arguments args);
    }
}
