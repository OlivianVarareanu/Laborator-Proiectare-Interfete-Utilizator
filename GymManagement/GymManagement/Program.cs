using System;
using System.Collections.Generic;

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
            Console.WriteLine("Members:");
            foreach (var member in Members)
            {
                Console.WriteLine($"- {member.Name} ({member.Age} years old)");
            }
        }

        public void DisplayTrainers()
        {
            Console.WriteLine("Trainers:");
            foreach (var trainer in Trainers)
            {
                Console.WriteLine($"- {trainer.Name} ({trainer.Specialization})");
            }
        }

        public void DisplayEquipment()
        {
            Console.WriteLine("Equipment:");
            foreach (var equipment in Equipment)
            {
                Console.WriteLine($"- {equipment.Name} ({equipment.Quantity} available)");
            }
        }

        public void SaveAllData()
        {
            using (StreamWriter writer = new StreamWriter("members.txt", true))
            {
                foreach (Member member in Members)
                {
                    writer.WriteLine($"{member.Name},{member.Age},{member.Email}");
                }
            }

            using (StreamWriter writer = new StreamWriter("trainers.txt", true))
            {
                foreach (Trainer trainer in Trainers)
                {
                    writer.WriteLine($"{trainer.Name},{trainer.Specialization}");
                }
            }

            using (StreamWriter writer = new StreamWriter("equipment.txt", true))
            {
                foreach (Equipment equipment in Equipment)
                {
                    writer.WriteLine($"{equipment.Name},{equipment.Quantity},{equipment.Type}");
                }
            }

            Console.WriteLine("Data saved successfully.");
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
                Console.WriteLine("There are no trainers to display.");
                return;
            }

            // Display each line (which represents a member)
            Console.WriteLine("----- Equipment -----");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }


        public List<Member> SearchMembers(string query)
            {
                List<Member> matches = new List<Member>();
                foreach (Member member in Members)
                {
                    if (member.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                    {
                        matches.Add(member);
                    }
                }
                return matches;
            }

        public List<Trainer> SearchTrainers(string query)
        {
            List<Trainer> matches = new List<Trainer>();
            foreach (Trainer trainer in Trainers)
            {
                if (trainer.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                {
                    matches.Add(trainer);
                }
            }
            return matches;
        }

        public List<Equipment> SearchEquipment(string query)
        {
            List<Equipment> matches = new List<Equipment>();
            foreach (Equipment equipment in Equipment)
            {
                if (equipment.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                {
                    matches.Add(equipment);
                }
            }
            return matches;
        }

   
        }

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

        public class Equipment
        {
            public string Name { get; set; }

            public string Type { get; set; }
            public int Quantity { get; set; }

    

            public Equipment(string name, string type , int quantity)
            {

                Name = name;
                Type= type;
                Quantity = quantity;
            }
        }



class Program
{
    static void Main(string[] args)
    {
        Gym gym = new Gym("Gym 1");
        bool done = false;

        while (!done)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Gym Management Console!");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. Add Trainer");
            Console.WriteLine("2. Add Member");
            Console.WriteLine("3. Add Equipment");
            Console.WriteLine("4. Save Data");
            Console.WriteLine("5. Show Members");
            Console.WriteLine("6. Show Trainers");
            Console.WriteLine("7. Show Equipment");
            Console.WriteLine("8. Search Members");
            Console.WriteLine("9. Search Trainers");
            Console.WriteLine("10. Search Equipment");
            Console.WriteLine("11. Exit");
            Console.WriteLine();

            Console.Write("Enter your choice (1-11): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter trainer name: ");
                    string trainerName = Console.ReadLine();
                    Console.Write("Enter trainer specialization: ");
                    string trainerSpecialization = Console.ReadLine();
                    gym.AddTrainer(new Trainer(trainerName, trainerSpecialization));
                    Console.WriteLine("Trainer added successfully!");
                    Console.WriteLine();
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Write("Enter member name: ");
                    string memberName = Console.ReadLine();
                    Console.Write("Enter member age: ");
                    int memberAge = int.Parse(Console.ReadLine());

                    Console.Write("Enter member email: ");
                    string memberEmail = Console.ReadLine();
                    gym.AddMember(new Member(memberName, memberAge ,memberEmail));
                    Console.WriteLine("Member added successfully!");
                    Console.WriteLine();
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;

                case "3":
                    Console.Write("Enter equipment name: ");
                    string equipmentName = Console.ReadLine();
                    Console.Write("Enter equipment type: ");
                    string equipmentType = Console.ReadLine();
                    Console.Write("Enter equipment quantity: ");
                    int equipmentQuantity = int.Parse(Console.ReadLine());
                    gym.AddEquipment(new Equipment(equipmentName, equipmentType, equipmentQuantity));
                    Console.WriteLine("Equipment added successfully!");
                    Console.WriteLine();
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;

                case "4":
                    gym.SaveAllData();
                    Console.WriteLine("All data was saved succesfully!");
                    Console.WriteLine();
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;

                case "5":
                    gym.ShowMemberList();
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;

                case "6":
                    gym.ShowTrainerList();
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "7":
                    gym.ShowEquipmentList();
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;

                case "8":
                    Console.Write("Enter search query: ");
                    string memberQuery = Console.ReadLine();
                    List<Member> memberMatches = gym.SearchMembers(memberQuery);
                    Console.WriteLine($"Found {memberMatches.Count} members matching query:");
                    foreach (Member member in memberMatches)
                    {
                        Console.WriteLine($"Name: {member.Name}, Age: {member.Age}");
                    }
                    Console.ReadKey();
                    break;

                case "9":
                    Console.Write("Enter search query: ");
                    string trainerQuery = Console.ReadLine();
                    List<Trainer> trainerMatches = gym.SearchTrainers(trainerQuery);
                    Console.WriteLine($"Found {trainerMatches.Count} trainers matching query:");
                    foreach (Trainer trainer in trainerMatches)
                    {
                        Console.WriteLine($"Name: {trainer.Name}, Specialty: {trainer.Specialization}");
                    }
                    Console.ReadKey();
                    break;
                case "10":
                    Console.Write("Enter search query: ");
                    string equipmentQuery = Console.ReadLine();
                    List<Equipment> equipmentMatches = gym.SearchEquipment(equipmentQuery);
                    Console.WriteLine($"Found {equipmentMatches.Count} equipment matching query:");
                    foreach (Equipment equipment in equipmentMatches)
                    {
                        Console.WriteLine($"Name: {equipment.Name}, Type: {equipment.Type}, Quantity:{equipment.Quantity}");
                    }
                    Console.ReadKey();
                    break;


                case "11":
                    done= true;
                    break;


                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}