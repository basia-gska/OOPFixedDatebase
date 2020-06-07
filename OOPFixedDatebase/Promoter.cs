using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFixedDatebase
{
    public abstract class Promoter
    {
        private string _firstName;
        private string _lastName;
        private long _cellPhone;


        public Promoter(string firstName, string lastName, long cellPhone)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cellPhone = cellPhone;

        }

        public string MyBusinessCard
        {
            get
            {
                return String.Format("{0} {1} {2}", _firstName, _lastName, _cellPhone);
            }
        }

        public void Promote()
        {
            ShareWithInnerCircle();
            UsePaidAds();
        }

        protected abstract void UsePaidAds();


        protected abstract void ShareWithInnerCircle();

    }
}
