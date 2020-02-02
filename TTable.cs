using System;
using System.Collections.Generic;
using System.Text;

namespace TimesTable
{
    class TTable
    {
        public int[,] table { get; set; }

        public TTable(int limit)
        {
            table = new int[limit , limit];

            for(int i = 1; i <= limit; i++)
            {
                for(int j = 1; j <= limit; j++)
                {
                    table[i-1, j-1] = i * j;
                }
            }
        }


        public void FlipTable(int direction)
        {
            int length = table.GetLength(0);
            int[,] tempTable = new int[table.GetLength(0), table.GetLength(1)];
            

            switch (direction)
            {
                case 1:
                    //flips diagonally / axis
                    for (int i = 1; i <= length; i++)
                    {
                        for (int j = 1; j <= length; j++)
                        {
                            tempTable[i - 1, j - 1] = table[length - i, length - j];
                        }
                    }
                    break;
                case 2:
                    //flips vertically
                    for (int i = 1; i <= length; i++)
                    {
                        for (int j = 1; j <= length; j++)
                        {
                            tempTable[i - 1, j - 1] = table[length - i, j - 1];
                        }
                    }
                    break;
                case 3:
                    //flips Horizontally
                    for (int i = 1; i <= length; i++)
                    {
                        for (int j = 1; j <= length; j++)
                        {
                            tempTable[i - 1, j - 1] = table[i - 1, length - j];
                        }
                    }
                    break;
                case 4:
                    //flips diagonally \ axis
                    for (int i = 1 ; i <=  length; i++)
                    {
                        for (int j = 1; j <= length; j++)
                        {
                            tempTable[i - 1  , j - 1] = table[j -1  , i -1];
                        }
                    }
                    break;
                default:
                    tempTable = table;
                    break;
            }

            
            table = tempTable;
        }

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    sb.Append(string.Format("{0,4}" , table[i, j]));
                    sb.Append(" ");
                }
                sb.Append("\n\n");
            }

            return sb.ToString();
        }



    }
}
