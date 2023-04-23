using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Equipment
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Equipment(string name,int quantity)
        {

            Name = name;
            Quantity = quantity;
        }

    }

    enum EquipmentName
    {
        Unknown,
        Gantere,
        Haltere,
        Discuri,
        JungleMachine
    }
}
