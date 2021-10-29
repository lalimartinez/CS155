/// Chapter No. 8		Exercise No. 1
/// File Name: DuelistGame.cs
/// @author: Zitlali Martinez
/// Date:  October 28, 2021
///
/// Problem Statement: Write a program that simulates 10,000 duels and keeps track of how many times each player wins.
/// 
/// Overall Plan:
/// 1) Create three duelist objects: Aaron, Bob, and Charlie 
/// 2) Create a count for each duelist to keep track of how mnay times they win
/// 3) At the beginning of each duel reset all the alive statuses to true and reset the condition of one player standing to false
/// 4) Check if Aaron is alive, if he is check if Bob is alive and if he is have Aaron shoot at Bob, else have him shoot at Charlie
/// 5) Check if both Bob and Charlie are alive, if they aren't change the condition of one player standing to true
/// 6) Check if Bob is alive, if he is check if Charlie is alive and if he is have Bob shoot at Charlie, else have him shoot at Aaron
/// 7) Check if both Aaron and Charlie are alive, if they aren't change the condition of one player standing to true
/// 8) Check if Charlie is alive, if he is check if Aaron is alive and if he is have Charlie shoot at Aaron, else have him shoot at Bob
/// 9) Check if both Bob and Aaron are alive, if they aren't change the condition of one player standing to true
/// 10) While there is not one player standing repeat steps 4-9
/// 11) Check to see which player is alive after the duel and increase their count by one
/// 12) Use a for loop to repeat steps 3-11 10,000 times
/// 13) Display how many games out of 10,000 each player won
/// 

using System;

namespace HomeworkWeek10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the 3 duelists
            Duelist Aaron = new Duelist("Aaron", .33);
            Duelist Bob = new Duelist("Bob", .55);
            Duelist Charlie = new Duelist("Charlie", .995);

            //Keep count of how many times each player wins 
            int aaronCount = 0;
            int bobCount = 0;
            int charlieCount = 0;

            //Boolean to keep track if there is only one player left standing 
            bool oneStanding;

            for (int i = 0; i < 10000; i++)
            {
                //Reset boolean that keeps track if there is one player standing to false
                oneStanding = false;
                //Rest status of players to alive = true 
                Aaron.Alive = true;
                Bob.Alive = true;
                Charlie.Alive = true;
                do
                {
                    //Have Aaron shoot and then check if the other two are still alive
                    if (Aaron.Alive == true)
                    {
                        if (Bob.Alive == true)
                            Aaron.ShootAtTarget(Bob);
                        else
                            Aaron.ShootAtTarget(Charlie);
                        if (Bob.Alive == false && Charlie.Alive == false)
                            oneStanding = true;
                    }

                    //Have Bob shoot next and then check if the other two are still alive
                    if (Bob.Alive == true)
                    {
                        if (Charlie.Alive == true)
                            Bob.ShootAtTarget(Charlie);
                        else
                            Bob.ShootAtTarget(Aaron);
                        if (Aaron.Alive == false && Charlie.Alive == false)
                            oneStanding = true;
                    }

                    //Have Charlie shoot and then check if the other two are still alive
                    if (Charlie.Alive == true)
                    {
                        if (Aaron.Alive == true)
                            Charlie.ShootAtTarget(Aaron);
                        else
                            Charlie.ShootAtTarget(Bob);
                        if (Bob.Alive == false && Aaron.Alive == false)
                            oneStanding = true;
                    }
                } while (oneStanding == false);

                //Check who won and increase their win count by one
                if (Aaron.Alive == true)
                    aaronCount++;
                else if (Bob.Alive == true)
                    bobCount++;
                else
                    charlieCount++;
            }

            //Print how many times each player won 
            Console.WriteLine("Aaaron won " + aaronCount + "/10000 duels.");
            Console.WriteLine("Bob won " + bobCount + "/10000 duels.");
            Console.WriteLine("Charlie won " + charlieCount + "/10000 duels.");

            Console.ReadLine();
        }
    }
}
