using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFixedDatebase
{
    public class XSClubPromoter : Promoter, IVlogger, IBodyBuilder
    {
        public XSClubPromoter(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
        {
        }

        public void Vlog()
        {
            Console.WriteLine("I vlog monthly with my Canon.");
        }

        public void WorkOut()
        {
            Console.WriteLine("I enjoy working out daily at my house.");
        }

        protected override void ShareWithInnerCircle()
        {
            Console.WriteLine("I share with my instagram followers.");
        }

        protected override void UsePaidAds()
        {
            Console.WriteLine("I use Google AdWords.");
        }
    }
}
