using System;
namespace CalculatorCommandParsing
{
    public interface IInputParserService
    {
        Application.CommandTypes ParseCommand(string command);
    }
}
