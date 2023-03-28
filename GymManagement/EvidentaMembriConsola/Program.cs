using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LibrarieModele;
using NivelStocareData;

namespace EvidentaMembriConsola
{


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
                        gym.AddMember(new Member(memberName, memberAge, memberEmail));
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
                        NivelStocareData.DataManager.SaveAllData(gym);
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
                        Gym.SearchMemberByName();
                        Console.ReadKey();
                        break;

                    case "9":
                        Gym.SearchTrainerByName();
                        Console.ReadKey();
                        break;
                    case "10":
                        Gym.SearchEquipmentByName();
                        Console.ReadKey();
                        break;


                    case "11":
                        done = true;
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

}
