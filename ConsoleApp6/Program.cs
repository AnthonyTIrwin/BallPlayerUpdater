using System;
using System.Collections.Generic;
using System.Diagnostics;
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

                foreach (DataRecord record in records.ToList())
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}, {4} {5}", record.Name, record.Popcorn, record.Position,
                        record.Height, record.Weight, record.Age);
                }


                for (int i = 0; i < 35; i++)
                {
                    Console.WriteLine("potato {0}", i);

                }
                Console.ReadLine();
            }
        }
    }
}

