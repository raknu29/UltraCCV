using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraCCV
{
    public class UltraCCV
    {
        public bool ValidateName(string name)
        {
            return Char.IsLetter(c: (char) name.Last()) 
                   && Char.IsLetter(c: (char) name.First()) 
                   && name.Contains(value: ' ') 
                   && !name.Any(predicate: x => char.IsNumber(c: x)) 
                   && !name.Any(char.IsSymbol);
        }
    }
}
