using System;

namespace Solo_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Сколько нужно пиромид - ");
            int sus = int.Parse(Console.ReadLine());

            Console.WriteLine("Высота пирамид - ");
            int kol = int.Parse(Console.ReadLine());

            Console.WriteLine("Отступ пирамид - ");
            int ots = int.Parse(Console.ReadLine());

            Console.Clear();

            int count = 0;

           
            for (int z = 0; z < sus; z++)
            {          
                    for (int i = 0; i < kol; i++)
                    {
                        Console.WriteLine();
                        count++;

                        for (int k = 0; k < count; k++)
                        {
                            Console.Write("#");
                      

                    }

                    }
                    for (int j = 0; j < ots; j++)
                    {
                        Console.WriteLine();
                    }

                    for (int i = kol; i > 0; i--)
                    {
                        Console.WriteLine();
                        count--;
                        for (int k = -1; k < count; k++)
                        {
                            Console.Write("#");
                        

                    }
                    }
                
                }
        }
    }
}
