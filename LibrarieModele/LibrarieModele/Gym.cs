using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Gym
    {
        public string Name { get; set; }
        public List<Member> Members { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Gym(string name)
        {
            Name = name;
            Members = new List<Member>();
            Trainers = new List<Trainer>();
            Equipment = new List<Equipment>();
        }

        public void AddMember(Member member)
        {
            Members.Add(member);
        }

        public void RemoveMember(Member member)
        {
            Members.Remove(member);
        }

        public void AddTrainer(Trainer trainer)
        {
            Trainers.Add(trainer);
        }

        public void RemoveTrainer(Trainer trainer)
        {
            Trainers.Remove(trainer);
        }

        public void AddEquipment(Equipment equipment)
        {
            Equipment.Add(equipment);
        }

        public void RemoveEquipment(Equipment equipment)
        {
            Equipment.Remove(equipment);
        }

        public void DisplayMembers()
        {
            if (Members.Count > 0)
            {
                Console.WriteLine("Members:");
                foreach (var member in Members)
                {
                    Console.WriteLine($"- Name:{member.Name}\t Email:{member.Email}\t Age:{member.Age}");
                }
            }

            else
            {
                Console.WriteLine("There are no members to display.");
            }
            }
           

        public void DisplayTrainers()
        {
            if (Trainers.Count > 0)
            {
                Console.WriteLine("Trainers:");
                foreach (var trainer in Trainers)
                {
                    Console.WriteLine($"- Name:{trainer.Name}\t Specialization {trainer.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("There are no trainers to display.");
            }
            }

        public void DisplayEquipment()
        {
            if (Equipment.Count > 0)
            {
                Console.WriteLine("Equipment:");
                foreach (var equipment in Equipment)
                {
                    Console.WriteLine($"- Name:{equipment.Name}\t Quantity:{equipment.Quantity}");
                }
            }
            else
                    { Console.WriteLine("There are no equipment to display."); 
        }
        }


        public void ShowMemberList()
        {
            // Read all lines from the members.txt file
            string[] lines = File.ReadAllLines("members.txt");

            // If there are no lines, display a message and return
            if (lines.Length == 0)
            {
                Console.WriteLine("There are no members to display.");
                return;
            }

            // Display each line (which represents a member)
            Console.WriteLine("----- Members -----");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public void ShowTrainerList()
        {
            // Read all lines from the members.txt file
            string[] lines = File.ReadAllLines("trainers.txt");

            // If there are no lines, display a message and return
            if (lines.Length == 0)
            {
                Console.WriteLine("There are no trainers to display.");
                return;
            }

            // Display each line (which represents a member)
            Console.WriteLine("----- Trainers -----");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }


        public void ShowEquipmentList()
        {
            // Read all lines from the members.txt file
            string[] lines = File.ReadAllLines("equipment.txt");

            // If there are no lines, display a message and return
            if (lines.Length == 0)
            {
                Console.WriteLine("There are no equipment to display.");
                return;
            }

            // Display each line (which represents a member)
            Console.WriteLine("----- Equipment -----");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        // Search for member by name in the members.txt file
        public static void SearchMemberByName()
        {
            Console.Write("Enter member name to search: ");
            string name = Console.ReadLine();
            bool found = false;

            // Read all lines from the members.txt file
            string[] lines = File.ReadAllLines(@"members.txt");

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                if (values[0].ToLower().Contains(name.ToLower()))
                {
                    Console.WriteLine($"Name: {values[0]}, Age: {values[1]}, Email: {values[2]}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Member not found.");
            }
        }

        // Search for trainer by name in the trainers.txt file
        public static void SearchTrainerByName()
        {
            Console.Write("Enter trainer name to search: ");
            string name = Console.ReadLine();
            bool found = false;

            // Read all lines from the trainers.txt file
            string[] lines = File.ReadAllLines(@"trainers.txt");

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                if (values[0].ToLower().Contains(name.ToLower()))
                {
                    Console.WriteLine($"ID:Name: {values[0]}, Specialization: {values[1]}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Trainer not found.");
            }
        }

        // Search for equipment by name in the equipment.txt file
        public static void SearchEquipmentByName()
        {
            Console.Write("Enter equipment name to search: ");
            string name = Console.ReadLine();
            bool found = false;

            // Read all lines from the equipment.txt file
            string[] lines = File.ReadAllLines(@"equipment.txt");

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                if (values[0].ToLower().Contains(name.ToLower()))
                {
                    Console.WriteLine($"Name: {values[0]},Quantity: {values[1]}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Equipment not found.");
            }
        }
    }
}
