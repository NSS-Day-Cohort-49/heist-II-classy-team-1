using System;

namespace Heist
{
    public class LockSpecialist : IRobber
    {
        public string name { get; set; }
        public int skillLevel { get; set; }
        public int percentageCut { get; set; }
        public string speciality {get; set; } = "Lock specialist";

        public void PerformSkill(Bank bank)
        {
            bank.alarmScore -= skillLevel;

            Console.WriteLine(@$"{name} is picking the locks. 
            Decrease vault score security by {skillLevel} points. 
            If the heist is successful, {name}'s cut will be {percentageCut}%.");

            
            if (bank.alarmScore <= 0)
            {
                Console.WriteLine($"{name} has picked the vault.");
            }
        }
    } 
}