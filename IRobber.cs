using System;

namespace Heist
{
    public interface IRobber
    {
        string name { get; set; }
        int skillLevel { get; set; }
        int percentageCut { get; set; }
        string speciality {get; set; }

        void PerformSkill(Bank bank);    
    }
}