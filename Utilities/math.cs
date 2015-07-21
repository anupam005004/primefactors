using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace math.primefactor
{
    public class math
    {
      static  public List<BigInteger> GetPrimeFactors(BigInteger inputNumber)
        {
            List<BigInteger> factors = new List<BigInteger>();
            int nextFactor = 2;
            while (inputNumber > 1)
            {
                if (inputNumber % nextFactor > 0)
                {
                    nextFactor += (nextFactor == 2) ? 1 : 2;
                    do
                    {
                        if (inputNumber % nextFactor == 0)
                        {
                            break;
                        }

                        nextFactor += 2;
                    } while (nextFactor < inputNumber);
                }
                inputNumber /= nextFactor;
                factors.Add(nextFactor);
            }
            return factors;
        }
    }
}
