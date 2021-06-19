using System;

namespace DatabasesSnelheidTesten
{
    class Program
    {
        static void Main(string[] args)
        {
            ADONET adonetTest = new ADONET();
            Console.WriteLine("DataBase test initiated");
            Console.WriteLine("Now testing; ADO.NET Inserts");
            Console.WriteLine("Press enter to start the tests");
            Console.WriteLine("1 row");
            Console.ReadLine();
            //Console.WriteLine("Time: " + adonetTest.testCreate(1) + "ms");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("1,000 rows");
            //Console.ReadLine();
            //Console.WriteLine("Time: " + adonetTest.testCreate(10) + "ms");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("100,000 rows");
            //Console.ReadLine();
            //Console.WriteLine("Time: " + adonetTest.testCreate(100) + "ms");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("1,000,000 rows");
            //Console.ReadLine();
            //Console.WriteLine("Time: " + adonetTest.testCreate(1000) + "ms");
            Console.WriteLine("End of test; ADO.NET Inserts");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Now testing; ADO.NET Get");
            Console.WriteLine("Press enter to start the tests");
            Console.WriteLine("1 row");
            Console.ReadLine();
            Console.WriteLine("Time: " + adonetTest.testRead(1) + "ms");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1,000 rows");
            Console.ReadLine();
            Console.WriteLine("Time: " + adonetTest.testRead(10) + "ms");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("100,000 rows");
            Console.ReadLine();
            Console.WriteLine("Time: " + adonetTest.testRead(100) + "ms");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1,000,000 rows");
            Console.ReadLine();
            Console.WriteLine("Time: " + adonetTest.testRead(1000) + "ms");
            Console.WriteLine("End of test; ADO.NET Get");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Now testing; ADO.NET Update");
            Console.WriteLine("Press enter to start the tests");
            Console.WriteLine("1 row");
            Console.ReadLine();
            Console.WriteLine("Time: " + adonetTest.testUpdate(1) + "ms");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1,000 rows");
            Console.ReadLine();
            Console.WriteLine("Time: " + adonetTest.testUpdate(10) + "ms");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("100,000 rows");
            Console.ReadLine();
            Console.WriteLine("Time: " + adonetTest.testUpdate(100) + "ms");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1,000,000 rows");
            Console.ReadLine();
            Console.WriteLine("Time: " + adonetTest.testUpdate(1000) + "ms");
            Console.WriteLine("End of test; ADO.NET Update");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Now testing; ADO.NET Delete");
            Console.WriteLine("Press enter to start the tests");
            Console.WriteLine("1 row");
            Console.ReadLine();
            Console.WriteLine("Time: " + adonetTest.testDelete(1) + "ms");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1,000 rows");
            Console.ReadLine();
            Console.WriteLine("Time: " + adonetTest.testDelete(10) + "ms");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("100,000 rows");
            Console.ReadLine();
            Console.WriteLine("Time: " + adonetTest.testDelete(100) + "ms");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1,000,000 rows");
            Console.ReadLine();
            Console.WriteLine("Time: " + adonetTest.testDelete(1000) + "ms");
            Console.WriteLine("End of test; ADO.NET Delete");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Press enter to stop the tests");
            Console.ReadLine();
        }
    }
}
