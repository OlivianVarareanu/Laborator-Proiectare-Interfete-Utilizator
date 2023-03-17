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
}

public class Member
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Member(string name, int age)
    {
        Name = name;
        Age = age;
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
    public int Quantity { get; set; }

    public Equipment(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
}