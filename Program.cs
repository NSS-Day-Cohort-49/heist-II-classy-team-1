using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        // initialize bank obj
        {   
            Bank chase = new Bank(){
                alarmScore = new Random().Next(101),
                vaultScore = new Random().Next(101),
                securityGuardScore = new Random().Next(101),
                cashOnHand = new Random().Next(50000, 1000001)
            };








            Bank.runReconReport(chase.alarmScore, chase.vaultScore, chase.securityGuardScore);
            // recon report

            // creating rolodex list of initial team of robbers:
            List<IRobber> rolodex = new List<IRobber>()
            {
                new Hacker()
                {
                    name = "Bonnie",
                    skillLevel = 40,
                    percentageCut = 70
                },
                new Hacker()
                {
                    name = "Snowden",
                    skillLevel = 30,
                    percentageCut = 10
                },
                new LockSpecialist()
                {
                    name = "Clyde",
                    skillLevel = 15,
                    percentageCut = 5
                },
                new LockSpecialist()
                {
                    name = "Luz",
                    skillLevel = 1337,
                    percentageCut = 88
                },
                new Muscle()
                {
                    name = "Joe",
                    skillLevel = 5,
                    percentageCut = 78
                },
                new Muscle()
                {
                    name = "Kelly",
                    skillLevel = 35,
                    percentageCut = 32
                }
            };

            Console.WriteLine($"Current number of operatives: {rolodex.Count}");

            string userInput = "";
            string name = "";
            int skillLevel = 0;
            int percentageCut = 0;
            int specialty = 0;
            bool addNewMember = true;

            int counter = 0;

            // method that prompts user for input to create new member:
            void createMember()
            {
                while (name == "")
                {
                    Console.Write("Please enter a member name: ");
                    userInput = Console.ReadLine();
                    name = userInput;
                }

                while (specialty <= 0)
                {
                    Console.WriteLine($@"
                    Please enter a number that corresponds to the member specialty:

                        1.) Hacker (Disables Alarms)
                        2.) Muscle (Disarms Guards)
                        3.) Lock Specialist (Cracks Vault)
                    ");
                    userInput = Console.ReadLine();

                    if (userInput == "")
                    {
                        specialty = 0;
                    }
                    else
                    {
                        specialty = int.Parse(userInput);
                    }
                }

                while (skillLevel <= 0)
                {
                    Console.Write("Please enter member skill level (between 1 and 100): ");
                    userInput = Console.ReadLine();

                    if (userInput == "")
                    {
                        skillLevel = 0;
                    }
                    else
                    {
                        skillLevel = int.Parse(userInput);
                    }
                }

                while (percentageCut <= 0)
                {
                    Console.Write("Please enter percentage cut member demands: ");
                    userInput = Console.ReadLine();

                    if (userInput == "")
                    {
                        percentageCut = 0;
                    }
                    else
                    {
                        percentageCut = int.Parse(userInput);
                    }
                }

                if (name != "" && skillLevel != 0 && specialty != 0 && percentageCut != 0)
                {
                    if (specialty == 1)
                    {
                        Hacker newMember = new Hacker() { name = name, skillLevel = skillLevel, percentageCut = percentageCut };
                        rolodex.Add(newMember);
                    }
                    else if (specialty == 2)
                    {
                        Muscle newMember = new Muscle() { name = name, skillLevel = skillLevel, percentageCut = percentageCut };
                        rolodex.Add(newMember);
                    }
                    else if (specialty == 3)
                    {
                        LockSpecialist newMember = new LockSpecialist() { name = name, skillLevel = skillLevel, percentageCut = percentageCut };
                        rolodex.Add(newMember);
                    }

                    // Prompt user to add new member or not:
                    Console.WriteLine();
                    Console.Write("Would you like to add a new member to the crew? (Y/N): ");
                    Console.WriteLine();
                    userInput = Console.ReadLine().ToLower();

                    if (userInput == "y")
                    {
                        addNewMember = true;
                    }
                    else
                    {
                        addNewMember = false;
                    }
                    // reset properties  to initial values:
                    name = "";
                    skillLevel = 0;
                    specialty = 0;
                    percentageCut = 0;
                }
            }

            // will create new member so long as variable is true:
            while (addNewMember)
            {
                createMember();
            }

            // Printing updated count and rolodex info:
            Console.WriteLine($"Number of Current Operatives: {rolodex.Count}");
            Console.WriteLine();
            Console.WriteLine("Robber Team Info:");
            Console.WriteLine();


            foreach (IRobber robber in rolodex)
            {
                Console.WriteLine($"{counter} {robber.name}'s skill level is {robber.skillLevel} with {robber.percentageCut}% of the cut. He is a {robber.speciality}.");
                counter++;
            }
        }
    }
}
