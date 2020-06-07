using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFixedDatebase
{
    public abstract class Writer : IVlogger
    {

        private string _firstName;
        private string _lastName;

        public string AuthorBio
        {
            get
            {
                return String.Format("My name is {0} {1}", _firstName, _lastName);
            }
        }

        public Writer(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public abstract void Vlog();

        public virtual void Write()
        {
            Console.WriteLine("I am a writer");
        }


    }
}
