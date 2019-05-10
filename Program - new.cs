using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.IO;


namespace functions
{
    class Program
    {
        String txtFileName;
        String xmlFileName;
        char rowDelimiter;
        char columDelimiter;
        string Data;
        string[] records;
        List<List<String>> list;
        int rowsSize;

        Program(String txtFileName, String xmlFileName, char rowDelimiter, char columDelimiter)
        {

            this.txtFileName = txtFileName;
            this.xmlFileName = xmlFileName;
            this.rowDelimiter = rowDelimiter;
            this.columDelimiter = columDelimiter;

        }

        public void Null()
        {

            for (int i = 0; i < Data.Length - 1; i++)
            {
                if (Data[i] == columDelimiter && Data[i + 1] == columDelimiter)
                    Data.Insert(i + 1, "Ǝ");
            }
        }


        public void getText()
        {

            Data = File.ReadAllText(txtFileName);
            records = Data.Split(rowDelimiter);
            list = new List<List<String>>();

            foreach (string record in records)
            {
                string[] fields = record.Split(columDelimiter);
                List<String> temp = new List<String>();

                foreach (string field in fields)
                {
                    temp.Add(field);
                }

                list.Add(temp);
            }

            Null();

            if (rowDelimiter == '\n')
                rowsSize = list.ElementAt(0).Count - 1;

        }

        public void setXML()
        {

            XmlWriter writer = XmlWriter.Create(xmlFileName);
            writer.WriteStartDocument();
            writer.WriteStartElement("Table");

            for (int i = 1; i < rowsSize; i++)
            {
                writer.WriteStartElement("Row" + i);
                for (int j = 0; j < list.ElementAt(0).Count; j++)
                {
                    writer.WriteStartElement(list.ElementAt(0).ElementAt(j));
                    writer.WriteString(list.ElementAt(i).ElementAt(j));
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

        }



        void setDefaultValue(int j, string defaultValue)
        {
            for (int i = 0; i < rowsSize; i++)
            {
                if (list[i][j] == "Ǝ")
                {
                    list[i][j] = defaultValue;
                }
            }
        }

        bool isNotNull(int j)
        {
            for (int i = 0; i < rowsSize; i++)
            {
                if (list[i][j] == "Ǝ")
                {
                    //view message box or something of that sort to show where the matching occured
                    Console.WriteLine("\tFATAL ERROR\nNull Values in column " + j.ToString() + ". Default value required.\n");
                    //
                    return false;
                }
            }
            return true;
        }


        bool isUnique(int j)
        {
            for (int i = 0; i < rowsSize; i++)
            {
                string temp = list[i][j];
                for (int ii = i + 1; ii < rowsSize; ii++)
                {
                    if (list[ii][j] == temp)
                    {
                        //view message box or something of that sort to show where the matching occured
                        Console.WriteLine("\tFATAL ERROR\n Non unique Values in column " + j.ToString() + ".\n");
                        //
                        return false;
                    }
                }
            }
            return true;
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        bool isGreaterThan(int j, int value, bool ints)
        {
            if(ints == true)
            {
                for( int i = 0; i < rowsSize; i++ )
                {
                    if (Convert.ToInt32(list[i][j]) <= value)
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < rowsSize; i++)
                {
                    if (list[i][j].Length <= value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        bool isGreaterThanOrEqual(int j, int value, bool ints)
        {
            if (ints == true)
            {
                for (int i = 0; i < rowsSize; i++)
                {
                    if (Convert.ToInt32(list[i][j]) < value)
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < rowsSize; i++)
                {
                    if (list[i][j].Length < value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        bool isLessThan(int j, int value, bool ints)
        {
            if (ints == true)
            {
                for (int i = 0; i < rowsSize; i++)
                {
                    if (Convert.ToInt32(list[i][j]) >= value)
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < rowsSize; i++)
                {
                    if (list[i][j].Length >= value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        bool isLessThanOrEqual(int j, int value, bool ints)
        {
            if (ints == true)
            {
                for (int i = 0; i < rowsSize; i++)
                {
                    if (Convert.ToInt32(list[i][j]) > value)
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < rowsSize; i++)
                {
                    if (list[i][j].Length > value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        bool isEqual(int j, int value, bool ints)
        {
            if (ints == true)
            {
                for (int i = 0; i < rowsSize; i++)
                {
                    if (Convert.ToInt32(list[i][j]) != value)
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < rowsSize; i++)
                {
                    if (list[i][j].Length != value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        bool isNotEqual(int j, int value, bool ints)
        {
            if (ints == true)
            {
                for (int i = 0; i < rowsSize; i++)
                {
                    if (Convert.ToInt32(list[i][j]) == value)
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < rowsSize; i++)
                {
                    if (list[i][j].Length == value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        static void Main(string[] args)
        {

        }
    }
}
