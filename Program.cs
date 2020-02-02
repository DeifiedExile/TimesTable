using System;

namespace TimesTable
{
    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Please enter a number between 3 and 9.");
            int size = Convert.ToInt16(Console.ReadLine());

            TTable table = new TTable(size);

            Console.WriteLine(table.ToString());

            int selection = 0;

            while(selection != 5)
            {
                Console.WriteLine("Flip on 1) Diag Left \n2) Vertical \n3) Horizon \n4) Diagonal Right \n5) To End");
                selection = Convert.ToInt16(Console.ReadLine());
                if(selection > 0 && selection < 5)
                {
                    table.FlipTable(selection);
                    Console.WriteLine(table.ToString());
                }
            }
            
            



        }

        
        
    }
}
