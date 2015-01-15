using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmklubben
{
    public class Member
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Steet { get; set; }
        public int Postal { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public Member()
        {

        }

        public Member(string fname, string lname, string street, int postal, int phone, string email) : this(-1, fname, lname, street, postal, phone, email)
        {

        }

        public Member(int id, string fname, string lname, string street, int postal, int phone, string email)
        {
            this.Id = id;
            this.FName = fname;
            this.LName = lname;
            this.Steet = street;
            this.Postal = postal;
            this.Phone = phone;
            this.Email = email;
        }

        public override string ToString()
        {
            return this.Id + ": " + this.LName + ", " + this.FName;
        }
    }
}
