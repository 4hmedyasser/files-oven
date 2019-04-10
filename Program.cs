using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;


namespace Test
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

        Program(String txtFileName, String xmlFileName, char rowDelimiter, char columDelimiter) {

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


        public void getText() {

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
                rowsSize = list.ElementAt(0).Count-1 ;

        }

        public void setXML()
        {

            XmlWriter writer = XmlWriter.Create(xmlFileName);
            writer.WriteStartDocument();
            writer.WriteStartElement("Table");

            for (int i = 1; i < rowsSize ; i++) {
                writer.WriteStartElement("Row"+i);
                for (int j = 0; j < list.ElementAt(0).Count; j++) {
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
                    Console.WriteLine("\tFATAL ERROR\nNull Values in column "+j.ToString()+". Default value required.\n");
                    //
                    return false;
                }
            }
            return true;
        }


        bool isUnique(int j)
        {
            for (int i = 0; i<rowsSize; i++)
            {
                string temp = list[i][j];
                for(int ii = i+1; ii<rowsSize; ii++)
                {
                    if(list[ii][j] == temp)
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

        bool isApplied(int j)
        {
            int choice;
            Console.WriteLine(" Apply conditions on\n   1- Numerical values(Equal, More or Less than a specific value).\n   2- Text fields.\n");
            choice = Console.Read();
            switch (choice)
            {
                case 1:
                    int choice2;
                    Console.WriteLine(" 1- Equals to value.\n 2- More than a value.\n 3- Less than a value.\n 4- More than or Equal a value.\n 5- Less than or Equal a value.\n 6- More than a value and Less than a value.\n 7- More than or Equal a value and Less than or Equal a value.\n 8- More than or Equal a value and Less than a value.\n 9- More than a value and Less than or Equal a value.\n");
                    choice2 = Console.Read();
                    int value;
                    int anotherValue;
                    switch (choice2)
                    {
                        case 1:// = 
                            Console.WriteLine("Enter the value: ");
                            value = Console.Read();
                            for(int i = 0; i < rowsSize; i++)
                            {
                                if( Convert.ToInt32(list[i][j]) != value )
                                {
                                    //view message box or something of that sort to show where the matching occured
                                    return false;
                                }
                            }
                            break;
                        case 2:// >
                            Console.WriteLine("Enter the value: ");
                            value = Console.Read();
                            for (int i = 0; i < rowsSize; i++)
                            {
                                if ( !( Convert.ToInt32(list[i][j]) > value )  )
                                {
                                    //view message box or something of that sort to show where the matching occured
                                    return false;
                                }
                            }
                            break;
                        case 3:// <
                            Console.WriteLine("Enter the value: ");
                            value = Console.Read();
                            for (int i = 0; i < rowsSize; i++)
                            {
                                if (  !( Convert.ToInt32(list[i][j]) < value )  )
                                {
                                    //view message box or something of that sort to show where the matching occured
                                    return false;
                                }
                            }
                            break;
                        case 4:// >=
                            Console.WriteLine("Enter the value: ");
                            value = Console.Read();
                            for (int i = 0; i < rowsSize; i++)
                            {
                                if (  !( Convert.ToInt32(list[i][j]) >= value )  )
                                {
                                    //view message box or something of that sort to show where the matching occured
                                    return false;
                                }
                            }
                            break;
                        case 5:// <=
                            Console.WriteLine("Enter the value: ");
                            value = Console.Read();
                            for (int i = 0; i < rowsSize; i++)
                            {
                                if (  !( Convert.ToInt32(list[i][j]) <= value )  )
                                {
                                    //view message box or something of that sort to show where the matching occured
                                    return false;
                                }
                            }
                            break;
                        case 6:// <     <
                            Console.WriteLine("More than: ");
                            value = Console.Read();
                            Console.WriteLine("Less than: ");
                            anotherValue = Console.Read();
                            for(int i = 0; i < rowsSize; i++)
                            {
                                if (   !(  ( Convert.ToInt32(list[i][j]) > value ) && ( Convert.ToInt32(list[i][j]) < anotherValue )  )   )
                                {
                                    //view message box or something of that sort to show where the matching occured
                                    return false;
                                }
                            }
                            break;
                        case 7:// <=    <=
                            Console.WriteLine("More than or Equal: ");
                            value = Console.Read();
                            Console.WriteLine("Less than or Equal: ");
                            anotherValue = Console.Read();
                            for (int i = 0; i < rowsSize; i++)
                            {
                                if (!( ( Convert.ToInt32(list[i][j]) >= value ) && (Convert.ToInt32(list[i][j]) <= anotherValue ) ) )
                                {
                                    //view message box or something of that sort to show where the matching occured
                                    return false;
                                }
                            }
                            break;
                        case 8:// <=    <
                            Console.WriteLine("More than or Equal: ");
                            value = Console.Read();
                            Console.WriteLine("Less than: ");
                            anotherValue = Console.Read();
                            for (int i = 0; i < rowsSize; i++)
                            {
                                if (!((Convert.ToInt32(list[i][j]) >= value ) && (Convert.ToInt32(list[i][j]) < anotherValue ) ) )
                                {
                                    //view message box or something of that sort to show where the matching occured
                                    return false;
                                }
                            }
                            break;
                        case 9:// <     <=
                            Console.WriteLine("More than: ");
                            value = Console.Read();
                            Console.WriteLine("Less than or Equal: ");
                            anotherValue = Console.Read();
                            for (int i = 0; i < rowsSize; i++)
                            {
                                if (!(( Convert.ToInt32(list[i][j]) > value ) && (Convert.ToInt32(list[i][j]) < anotherValue ) ) )
                                {
                                    //view message box or something of that sort to show where the matching occured
                                    return false;
                                }
                            }
                            break;
                        default:
                            //view message box or something of that sort to show where the matching occured
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine(" 1- Text has a specific number of characters.\n");
                    choice2 = Console.Read();
                    switch (choice2)
                    {
                        case 1:
                            int choice3;
                            Console.WriteLine(" 1- Equals to value.\n 2- More than a value.\n 3- Less than a value.\n 4- More than or Equal a value.\n 5- Less than or Equal a value.\n 6- More than a value and Less than a value.\n 7- More than or Equal a value and Less than or Equal a value.\n 8- More than or Equal a value and Less than a value.\n 9- More than a value and Less than or Equal a value.\n");
                            choice3 = Console.Read();
                            switch (choice3)
                            {
                                case 1:// = 
                                    Console.WriteLine("Enter the value: ");
                                    value = Console.Read();
                                    for (int i = 0; i < rowsSize; i++)
                                    {
                                        if (list[i][j].Length != value)
                                        {
                                            //view message box or something of that sort to show where the matching occured
                                            return false;
                                        }
                                    }
                                    break;
                                case 2:// >
                                    Console.WriteLine("Enter the value: ");
                                    value = Console.Read();
                                    for (int i = 0; i < rowsSize; i++)
                                    {
                                        if ( !( list[i][j].Length > value )  )
                                        {
                                            //view message box or something of that sort to show where the matching occured
                                            return false;
                                        }
                                    }
                                    break;
                                case 3:// <
                                    Console.WriteLine("Enter the value: ");
                                    value = Console.Read();
                                    for (int i = 0; i < rowsSize; i++)
                                    {
                                        if (  !( list[i][j].Length < value )  )
                                        {
                                            //view message box or something of that sort to show where the matching occured
                                            return false;
                                        }
                                    }
                                    break;
                                case 4:// >=
                                    Console.WriteLine("Enter the value: ");
                                    value = Console.Read();
                                    for (int i = 0; i < rowsSize; i++)
                                    {
                                        if (!( list[i][j].Length >= value )  )
                                        {
                                            //view message box or something of that sort to show where the matching occured
                                            return false;
                                        }
                                    }
                                    break;
                                case 5:// <=
                                    Console.WriteLine("Enter the value: ");
                                    value = Console.Read();
                                    for (int i = 0; i < rowsSize; i++)
                                    {
                                        if (  !( list[i][j].Length <= value )  )
                                        {
                                            //view message box or something of that sort to show where the matching occured
                                            return false;
                                        }
                                    }
                                    break;
                                case 6:// <     <
                                    Console.WriteLine("More than: ");
                                    value = Console.Read();
                                    Console.WriteLine("Less than: ");
                                    anotherValue = Console.Read();
                                    for (int i = 0; i < rowsSize; i++)
                                    {
                                        if (! ( ( list[i][j].Length > value ) && ( list[i][j].Length < anotherValue) )  )
                                        {
                                            //view message box or something of that sort to show where the matching occured
                                            return false;
                                        }
                                    }
                                    break;
                                case 7:// <=    <=
                                    Console.WriteLine("More than or Equal: ");
                                    value = Console.Read();
                                    Console.WriteLine("Less than or Equal: ");
                                    anotherValue = Console.Read();
                                    for (int i = 0; i < rowsSize; i++)
                                    {
                                        if (!   (  ( list[i][j].Length >= value ) && ( list[i][j].Length <= anotherValue )  )   )
                                        {
                                            //view message box or something of that sort to show where the matching occured
                                            return false;
                                        }
                                    }
                                    break;
                                case 8:// <=    <
                                    Console.WriteLine("More than or Equal: ");
                                    value = Console.Read();
                                    Console.WriteLine("Less than: ");
                                    anotherValue = Console.Read();
                                    for (int i = 0; i < rowsSize; i++)
                                    {
                                        if (!  (  ( list[i][j].Length >= value )  && ( list[i][j].Length  < anotherValue )  )   )
                                        {
                                            //view message box or something of that sort to show where the matching occured
                                            return false;
                                        }
                                    }
                                    break;
                                case 9:// <     <=
                                    Console.WriteLine("More than: ");
                                    value = Console.Read();
                                    Console.WriteLine("Less than or Equal: ");
                                    anotherValue = Console.Read();
                                    for (int i = 0; i < rowsSize; i++)
                                    {
                                        if (!   (  ( list[i][j].Length > value ) && ( list[i][j].Length < anotherValue )  )   )
                                        {
                                            //view message box or something of that sort to show where the matching occured
                                            return false;
                                        }
                                    }
                                    break;
                                default:
                                    //view message box or something of that sort to show where the matching occured
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    //view message box or something of that sort to show where the matching occured
                    break;
            }
            return true;
        }        
        static void Main(string[] args)
        {

        }
    }
}
