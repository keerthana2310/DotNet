using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace car_pooling
{
    internal class Member
    {
        private long _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _contactNumber;
        private string _licenseNumber;
        private DateTime _licenseStartDate;
        private DateTime _licenseExpiryDate;



        public long Id
        {
            get
            { return _id; }
            set
            {
                _id = value;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }

        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string ContactNumber
        {
            get
            {
                return _contactNumber;
            }
            set
            {
                _contactNumber = value;
            }
        }
        public string LicenseNumber
        {
            get
            {
                return _licenseNumber;
            }
            set
            {
                _licenseNumber = value;
            }
        }
        public DateTime LicenseStartDate
        {
            get
            {
                return _licenseExpiryDate;
            }
            set
            {
                _licenseExpiryDate = value;
            }
        }
        public DateTime LicenseExpiryDate
        {
            get
            {
                return _licenseExpiryDate;
            }
            set
            {
                _licenseExpiryDate = value;
            }
        }
        public Member()
        {

        }
        public Member(long id, string firstName, string lastName, string email, string contactNumber, string licenseNumber, DateTime licenseStartDate, DateTime licenseExpiryDate)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _contactNumber = contactNumber;
            _licenseNumber = licenseNumber;
            _licenseStartDate = licenseStartDate;
            _licenseExpiryDate = licenseExpiryDate;
        }
        
        public override string ToString()
        {
            //int i = 0;
            return string.Format("Member{0} Name : {1}, {2}\n  Member contact details : {3} {4}" ,1,2, _firstName , _lastName, _contactNumber , _email);
            
        }
        public override bool Equals(object obj)
        {
            Member a = obj as Member;
            if (a.Email == Email && a.ContactNumber == ContactNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
