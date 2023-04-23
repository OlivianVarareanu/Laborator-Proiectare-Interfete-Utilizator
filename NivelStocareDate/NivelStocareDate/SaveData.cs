using System;
using System.IO;
using LibrarieModele;

namespace NivelStocareData
{
    public static class DataManager
    {
        public static void SaveAllData(Gym gym)
        {
            string membersFilePath = @"members.txt";
            string trainersFilePath = @"trainers.txt";
            string equipmentFilePath = @"equipment.txt";

            // Save members to file
            using (StreamWriter writer = new StreamWriter(membersFilePath, true))
            {
                foreach (Member member in gym.Members)
                {
                    writer.WriteLine($"{member.Name},{member.Age},{member.Email}");
                }
            }

            // Save trainers to file
            using (StreamWriter writer = new StreamWriter(trainersFilePath, true))
            {
                foreach (Trainer trainer in gym.Trainers)
                {
                    writer.WriteLine($"{trainer.Name},{trainer.Specialization}");
                }
            }

            // Save equipment to file
            using (StreamWriter writer = new StreamWriter(equipmentFilePath, true))
            {
                foreach (Equipment equipment in gym.Equipment)
                {
                    writer.WriteLine($"{equipment.Name},{equipment.Quantity}");
                }
            }
        }

        public static void SaveIntoObjectVector(Gym gym)
        {


            string[] equipmentFilePath = File.ReadAllLines("equipment.txt");
            string[] trainersFilePath = File.ReadAllLines("trainers.txt");
            string[] membersFilePath = File.ReadAllLines("members.txt");




            foreach (string line in equipmentFilePath)
            {
                string[] values = line.Split(',');
                Equipment eq = new Equipment(values[0],Convert.ToInt32(values[1]));
                gym.AddEquipment(eq);
            }

            foreach (string line in trainersFilePath)
            {
                string[] values = line.Split(',');
                Trainer tr = new Trainer(values[0], values[1]);
                gym.AddTrainer(tr);
            }

            foreach (string line in membersFilePath)
            {
                string[] values = line.Split(',');
                Member mem = new Member(values[0], Convert.ToInt32(values[1]), values[2]);
                gym.AddMember(mem);
            }
        }
    }
}
