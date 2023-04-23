using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Trainer
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public Trainer(string name, string specialization)
        {
            Name = name;
            Specialization = specialization;
        }
    }
}
