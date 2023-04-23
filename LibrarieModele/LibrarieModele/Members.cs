using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Email { get; set; }

        public Member(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

    }

}
