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

                //CSVReader will now read the whole file into an enumerable
                IEnumerable<DataRecord> records = reader.GetRecords<DataRecord>();
                Console.WriteLine("Please enter team initials for team roster:");
                string nme = Console.ReadLine();
                foreach (DataRecord record in records)
                {

                    if (record.Popcorn == nme)
                    {
                    Console.WriteLine("{0}, {1}, {2}, {3}, {4} {5}", record.Name, record.Popcorn, record.Position,
                        record.Height, record.Weight, record.Age);
                      
                    }
                    else {

                       
                      
                    }

                 
                }



                Console.WriteLine("Which player would you like to modify?");
                string plyr = Console.ReadLine();



                foreach (DataRecord plr in records)
                {

                    if (plr.Popcorn == nme)
                    {
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4} {5}", plr.Name, plr.Popcorn, plr.Position,
                            plr.Height, plr.Weight, plr.Age);

                    }
                    else
                    {



                    }


                }


            }
                    
                Console.ReadLine();
            }
        }
    }


