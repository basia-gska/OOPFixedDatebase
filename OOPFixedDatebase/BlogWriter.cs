using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFixedDatebase
{
    public class BlogWriter : Writer
    {
        public BlogWriter(string firstName, string lastName) : base(firstName, lastName)
        {
        }


        public override void Vlog()
        {
            Console.WriteLine("I vlog daily using my GoPro.");
        }

        public override void Write()
        {
            Console.WriteLine("I am a blog writer.");
        }
    }
}
