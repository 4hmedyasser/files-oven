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
