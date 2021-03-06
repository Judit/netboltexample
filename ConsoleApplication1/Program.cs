﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4j.Driver.V1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = GraphDatabase.Driver("bolt://sb10.stations.graphenedb.com:24786", AuthTokens.Basic("db303", "e00nmVjiUcGgGC2grCBb"));

            using (var session = driver.Session()) {
                Console.WriteLine(session);
                var result = session.Run("MATCH (n) RETURN count(n)");
                Console.WriteLine(result);
            }
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
