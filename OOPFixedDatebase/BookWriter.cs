using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFixedDatebase
{
    public class BookWriter : Writer
    {
        public BookWriter(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Vlog()
        {
            Console.WriteLine("I vlog once a week using my phone.");
        }

        public override void Write()
        {
            Console.WriteLine("I am a book writer.");
        }
    }
}
