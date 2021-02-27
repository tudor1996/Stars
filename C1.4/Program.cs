using System;

namespace C1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int col, lin ;
            try { 
            
                Console.Write("Cate stelute ");
                col = int.Parse(Console.ReadLine());
                Console.Write("Pe cate linii ");
                lin = int.Parse(Console.ReadLine());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                col = 0;
                lin = 0;
            }

            for (int j = 0; j < lin; j++)
            {
                for (int i = 0; i < col; i++)
                    Console.Write(" * ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
