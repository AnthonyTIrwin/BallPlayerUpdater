using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace BallPlayerUpdater
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var sr = new StreamReader(@"c:\temp\mlb_players.csv"))
            {
                var reader = new CsvReader(sr);


                IEnumerable<DataRecord> records = reader.GetRecords<DataRecord>();
                Console.WriteLine("Please enter team initials for team roster:");
                string Name = Console.ReadLine();

                foreach (DataRecord record in records)
                {
            



                    if (record.Name == Name)
                    {
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4} {5}", record.Name, record.Popcorn, record.Position,
                            record.Height, record.Weight, record.Age);
                        Console.WriteLine("What is the new team?");
                        record.Popcorn = Console.ReadLine();
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4} {5}", record.Name, record.Popcorn, record.Position,
                           record.Height, record.Weight, record.Age);

                     




                    }


                }

                Console.ReadLine();

            }


        }








    }
                    
               
}
        
    


