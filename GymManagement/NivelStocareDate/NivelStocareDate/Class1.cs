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
            using (StreamWriter writer = new StreamWriter(membersFilePath,true))
            {
                foreach (Member member in gym.Members)
                {
                    writer.WriteLine($"{member.Name},{member.Age},{member.Email}");
                }
            }

            // Save trainers to file
            using (StreamWriter writer = new StreamWriter(trainersFilePath,true))
            {
                foreach (Trainer trainer in gym.Trainers)
                {
                    writer.WriteLine($"{trainer.Name},{trainer.Specialization}");
                }
            }

            // Save equipment to file
            using (StreamWriter writer = new StreamWriter(equipmentFilePath,true))
            {
                foreach (Equipment equipment in gym.Equipment)
                {
                    writer.WriteLine($"{equipment.Name},{equipment.Type},{equipment.Quantity}");
                }
            }
        }

    }
}
