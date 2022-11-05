using System.Numerics;

namespace FermatPrimalityTest
{
    public class Test
    {
        public bool CheckPrimality(int number)
        {
            // start Random system to get random values for a
            System.Random r = new System.Random();
            
            //numbers less than 1 cannot be prime number
            if (number <= 1) { return false; }
            
            //numbers 2 and 3 are prime numbers, so start checking above 3
            else if (number > 3)
            {
                // k is a parameter that determines the number of times to test
                // its important to avoid a "Fermat liar"
                int k = 3;                
                while(k > 0)
                {                    
                    // getting a random number below the number to check
                    //using "BigIntegers.Pow" because numbers here are long. 
                    int a = r.Next(2, number - 2);
                    if (BigInteger.Pow(a,(number - 1)) % number != 1)
                    {
                        // not prime number
                        return false;
                    }
                    k--;
                }
            }            
            return true;
        }
    }
}