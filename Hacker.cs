namespace Heist
{
    public class Hacker : IRobber
    {
        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= SkillLevel;

            Console.WriteLine(@$"{Name} is hacking the alarm system. 
            Decrease alarm score security by {SkillLevel} points. 
            If the heist is successful, {Name}'s cut will be {PercentageCut}%.");

            
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has disable the alarm system.");
            }
        }
    } 
}