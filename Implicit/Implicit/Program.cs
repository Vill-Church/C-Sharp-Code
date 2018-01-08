using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit
{
    class Program
    {
        static void Main(string[] args)
        {
            Dim say = Console.ReadLine();
            Console.WriteLine(say.getWord());
            Console.Read();
        }
    }
    public class Dim
    {
        private string word;
        public Dim(string _word)
        {
            word = _word;
        }
        public static implicit operator Dim(string _word)
        {
            if (_word == null)
            {
                return null;
            }
            return new Dim(_word);
        }
        public string getWord() {
            return word;
        }
    }
}
