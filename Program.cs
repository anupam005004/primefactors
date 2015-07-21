using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace math.primefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file location");
            string path = Console.ReadLine();
            try
            {
                FileInfo file = new FileInfo(path);
                List<string> lstNumbers = new List<string>();
                using (StreamReader reader = file.OpenText())
                {
                    while (!reader.EndOfStream)
                    {
                        lstNumbers.Add(reader.ReadLine());
                    }
                }
                lstNumbers.ForEach(n =>
                {
                    BigInteger num;
                    List<BigInteger> factors;
                    string outputString = "";
                    if (BigInteger.TryParse(n, out num))
                    {
                        math math = new math();
                        factors = math.GetPrimeFactors(num);
                        factors.ForEach(f => outputString += f.ToString() + ", ");
                        Console.WriteLine("Prime factors of {0} is/are {1}  ", num, outputString.Remove(outputString.LastIndexOf(",")));
                    }
                    else
                        Console.WriteLine("Invalid # " + n);

                });

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
      
    }
}
