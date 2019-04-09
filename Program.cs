using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test
{
    class Program
    {
        string[] cellDefaults(int no0fColumns)
        {
            string[] defaultValues = new string[no0fColumns];
            for (int i = 0; i<no0fColumns; i++)
            {
                defaultValues[i]=Console.ReadLine();
            }
            return defaultValues;
        }
        void nullCell(bool canBeNull)
        {
            if (!canBeNull)
            {
                int no0fColumns = Console.Read();
                cellDefaults(no0fColumns);
            }
        }
        bool isUnique(List<List<string>> list)
        {
            for(int j = 0; j < list[0].Count(); j++)//used zero as all columns should have the same size even if one of the columns carried a null value it should have been replaced with '198 142'
            {
                for(int i = 0; i < list.Count(); i++)
                {
                    string temp = list[i][j];
                    for(int ii = 0; ii < list.Count()-i; ii++)
                    {
                        if (temp == list[ii][j])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {

        }
    }
}
