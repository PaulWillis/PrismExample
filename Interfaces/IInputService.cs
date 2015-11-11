using System;
namespace InputOutput
{
    public interface IInputService
    {
        Application.Arguments ReadArguments();
        string ReadCommand();
    }
}
