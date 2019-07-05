namespace MilitaryEliteExercise.Core
{
    using MilitaryEliteExercise.Contracts;
    using MilitaryEliteExercise.Enums;
    using MilitaryEliteExercise.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine

    {
        private ICollection<ISoldier> soldiers;
        private ISoldier soldier;

        public Engine()
        {
            soldiers = new List<ISoldier> { };
        }

        public void Run()
        {
            //•	Private: “Private <id> <firstName> <lastName> <salary>”
            //•	LeutenantGeneral: “LieutenantGeneral <id> <firstName> <lastName> <salary> <private1Id> <private2Id> … <privateNId>” 
            //•	Engineer: “Engineer <id> <firstName> <lastName> <salary> <corps> <repair1Part> <repair1Hours> … <repairNPart> <repairNHours>”
            //•	Commando: “Commando <id> <firstName> <lastName> <salary> <corps> <mission1CodeName>  <mission1state> … <missionNCodeName> <missionNstate>” 
            //•	Spy: “Spy <id> <firstName> <lastName> <codeNumber>”

            string inputArg = Console.ReadLine();

            while (inputArg != "End")
            {

                string[] partitions = inputArg
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = partitions[0];
                string id = partitions[1];
                string firstName = partitions[2];
                string lastName = partitions[3];


                if (type == "Private")
                {
                    decimal salary = decimal.Parse(partitions[4]);

                    soldier = GetPrivate(id, firstName, lastName, salary);

                    if (soldier != null)
                    {
                        soldiers.Add(soldier);
                    }

                }

                else if (type == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(partitions[4]);

                    soldier = GetLeutenant(id, firstName, lastName, salary, partitions);

                    if (soldier != null)
                    {
                        soldiers.Add(soldier);
                    }

                }
                else if (type == "Engineer")
                {
                    decimal salary = decimal.Parse(partitions[4]);
                    string corps = partitions[5];

                    soldier = GetEngineer(id, firstName, lastName, salary, partitions);

                    if (soldier != null)
                    {
                        soldiers.Add(soldier);
                    }

                }

                else if (type == "Commando")
                {
                    decimal salary = decimal.Parse(partitions[4]);
                    string corps = partitions[5];

                    soldier = GetCommando(id, firstName, lastName, salary, partitions);

                    if (soldier != null)
                    {
                        soldiers.Add(soldier);
                    }

                }
                else if (type == "Spy")
                {
                    int codeNumber = int.Parse(partitions[4]);

                    soldier = GetSpy(id, firstName, lastName, codeNumber);

                    if (soldier!=null)
                    {
                        soldiers.Add(soldier);
                    }
                }


                inputArg = Console.ReadLine();
            }

            foreach (var s in soldiers)
            {
                Console.WriteLine(s);
            }

           
        }
        private ISoldier GetCommando(string id, string firstName, string lastName, decimal salary, string[] partitions)
        {

            string corpsAsString = partitions[5];

            if (!Enum.TryParse(corpsAsString, out Corps corps))
            {
                return null;
            }


            ICommando commando = new Commando(id, firstName, lastName, salary, corps);

            for (int i = 6; i < partitions.Length; i+=2)
            {
                string codeName = partitions[i];
                string stateAsString = partitions[i + 1];

                if (Enum.TryParse(stateAsString, out MissionState state))
                {

                    IMission mission = new Mission(codeName, state);

                    commando.Missions.Add(mission);
                }


            }

            return commando;
        }

        private ISoldier GetEngineer(string id, string firstName, string lastName, decimal salary, string[] partitions)
        {
            string corpsAsString = partitions[5];

            if (!Enum.TryParse(corpsAsString, out Corps corps))
            {
                return null;
            }


            IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

            for (int i = 6; i < partitions.Length; i += 2)
            {
                string repairPart = partitions[i];
                string repairHoursAsString = partitions[i + 1];

                if (!int.TryParse(repairHoursAsString, out int hoursWorked))
                {
                    return engineer;
                }

                IRepair repair = new Repair(repairPart, hoursWorked);

                engineer.Repairs.Add(repair);
            }

            return engineer;

        }

        private ISoldier GetLeutenant(string id, string firstName, string lastName, decimal salary, string[] partitions)
        {
            Leutenant leutenant = new Leutenant(id, firstName, lastName, salary);


            for (int i = 5; i < partitions.Length; i++)
            {
                string currentId = partitions[i];
                var currentPrivate = soldiers.FirstOrDefault(p => p.Id == currentId);

                leutenant.Privates.Add((IPrivate)currentPrivate);

            }

            return leutenant;
        }

        private ISoldier GetPrivate(string id, string firstName, string lastName, decimal salary)
        {
            return new Private(id, firstName, lastName, salary);

        }

        private ISoldier GetSpy(string id, string firstName, string lastName, int codeNumber)
        {
            ISpy spy = new Spy(id, firstName, lastName, codeNumber);

            return spy;
        }
    }
}
