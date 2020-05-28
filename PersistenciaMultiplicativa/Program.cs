using System;

namespace PersistenciaMultiplicativa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculatePersistence(999999));
        }

        public static int CalculatePersistence(int num)
        {
            string numasString = Convert.ToString(num);
            int counter = 0;

            while (numasString.Length > 1)
            {
                int temp = (int)Char.GetNumericValue(numasString[0]);

                for (int i = 0; i < numasString.Length - 1; i++)
                {
                    temp *= (int)Char.GetNumericValue(numasString[i + 1]);
                }

                numasString = Convert.ToString(temp);

                counter++;

            }

            return counter;
        }
    }
}
