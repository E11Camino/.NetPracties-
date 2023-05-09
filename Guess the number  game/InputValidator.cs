using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number__game
{
    public class InputValidator
    {
        public bool TryParseInputNumber(string userInput, out int parsed)
        {
            if (int.TryParse(userInput, out parsed) && parsed > 0 && parsed < 101)
            {
                return true;
            }
            parsed = -1;
            return false;
        }


        public bool TryParseInputChar(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                return false;
            }
            if (userInput.Any(c => !char.IsLetter(c)))
            {
                return false;
            }
            return true;
        }
        void ShowError()
        {
            Console.WriteLine("Enter valid value");
            Thread.Sleep(1000);
            Console.CursorTop -= 2;
            Console.CursorLeft = 0;
            Console.WriteLine(new String(' ', 50));
            Console.WriteLine(new String(' ', 50));
            Console.CursorTop -= 2;
        }
    }
}
