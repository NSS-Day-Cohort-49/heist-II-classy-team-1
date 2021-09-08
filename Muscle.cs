using System;

namespace Heist
{
    public class Muscle : IRobber
    {
        public string name { get; set; }
        public int skillLevel { get; set; }
        public int percentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.alarmScore -= skillLevel;

            Console.WriteLine(@$"{name} is beating up guards. 
            Decrease guard score security by {skillLevel} points. 
            If the heist is successful, {name}'s cut will be {percentageCut}%.");

            
            if (bank.alarmScore <= 0)
            {
                Console.WriteLine($"{name} has beat up everyone.");
            }
        }
    } 
}