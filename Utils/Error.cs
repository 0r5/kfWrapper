using System;
using System.Drawing;
using Console = Colorful.Console;

namespace kfWrapper.API.Utils
{
    public class Error
    {
        public static void ShowError(string message)
        {
            Console.WriteLine($"Oops, something went wrong while {message}", Color.Red);
            Environment.Exit(1);
        }
    }
}
