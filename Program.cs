using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
        
            List <IRobber> rolodex = new List<IRobber>() {
                new Hacker (){
                    name = "Bonnie",
                    skillLevel = 40,
                    percentageCut = 70
                },
                new Hacker(){
                    name = "Snowden",
                    skillLevel = 30,
                    percentageCut = 10
                },
                new LockSpecialist(){
                    name = "Clyde",
                    skillLevel = 15,
                    percentageCut = 5
                },
                new LockSpecialist(){
                    name = "Luz",
                    skillLevel = 1337,
                    percentageCut = 88
                },
                new Muscle(){
                    name = "Joe",
                    skillLevel = 5,
                    percentageCut = 78
                },
                new Muscle(){
                    name = "Kelly",
                    skillLevel = 35,
                    percentageCut = 32
                }     
            };


        }
    }
}
