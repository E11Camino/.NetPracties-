using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practies
{
    public class UserInputValidator
    {
        public bool IsNameValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            if (name.Any(c => !char.IsLetter(c)))
            {
                return false;
            }
            return true;
        }

        public bool TryParseAge(string age, out int parsed)
        {
            if (int.TryParse(age, out parsed) && parsed > 4 && parsed < 110)
            {
                return true;    
            }
            parsed = -1;
            return false;
        }

        public bool TryParseColor(string color, out Colors parsed)
        {
            if (Enum.TryParse(color, true, out parsed))
            {
                return true;
            }
            return false;
        }
   }
}
