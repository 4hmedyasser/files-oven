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
using System.Data.OleDb;
using GemBox.Spreadsheet;

namespace ImportingApplyingModel
{
    public static class Globals
    {
        public static String txtFileName;

        public static String xmlFileName;

        public static String xlsxFileName;

        public static char rowDelimiter;

        public static char columDelimiter;

        public static List<List<String>> list;

        public static int rowsSize;

        public static int selectedColumn;
//////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////
        public static void getExcel()

        {

            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile workbook = ExcelFile.Load(xlsxFileName);
            ExcelWorksheet worksheet = workbook.Worksheets.ActiveWorksheet;
            
            CellRange range = worksheet.GetUsedCellRange(true);

            Globals.list = new List<List<string>>();

            for (int r = range.FirstRowIndex; r <= range.LastRowIndex; r++)

            {

                List<String> tempList = new List<string>();


                for (int c = range.FirstColumnIndex; c <= range.LastColumnIndex; c++)

                {

                    ExcelCell cell = range[r - range.FirstRowIndex, c - range.FirstColumnIndex];



                    //string cellName = CellRange.RowColumnToPosition(r, c);

                    //string cellRow = ExcelRowCollection.RowIndexToName(r);

                    //string cellColumn = ExcelColumnCollection.ColumnIndexToName(c);



                    if (cell.Value == null)

                    {

                        tempList.Add("Ǝ");

                    }
                    else
                    {

                        tempList.Add(cell.StringValue);

                    }

                }



                Globals.list.Add(tempList);

                

            }

                Globals.rowsSize = Globals.list.Count;



        }
        //////////////////////////////////////////////////////////////////////////////


        public static void getText()
        {
            
            String Data = File.ReadAllText(Globals.txtFileName);
            String[] records = Data.Split(Globals.rowDelimiter);

            Globals.list = new List<List<string>>();

            foreach (String record in records)
            {
                String[] fields = record.Split(Globals.columDelimiter);
                List<String> temp = new List<String>();

                foreach (String field in fields)
                {
                    temp.Add(field);
                }

                Globals.list.Add(temp);

            }


            for (int i = 0; i < Data.Length - 1; i++)
            {
                if (Data[i] == Globals.columDelimiter && Data[i + 1] == Globals.columDelimiter)
                    Data.Insert(i + 1, "Ǝ");
            }

            for (int i = 0; i < Data.Length - 1; i++)
            {
                if (Data[i] == Globals.columDelimiter && Data[i + 1] == Globals.columDelimiter)
                    Data.Insert(i + 1, "Ǝ");
            }

                if (rowDelimiter == '\n')
                {
                    Globals.rowsSize = Globals.list.Count - 1;
                }
                else
                {
                    Globals.rowsSize = Globals.list.Count;
                }

        }

        public static void setXML()

        {

            XmlWriter writer = XmlWriter.Create(Globals.xmlFileName);
            writer.WriteStartDocument();
            writer.WriteStartElement("Table");

            for (int i = 1; i < Globals.rowsSize; i++)
            {
                writer.WriteStartElement("Row" + i);
                for (int j = 0; j < Globals.list.ElementAt(0).Count; j++)
                {
                    writer.WriteStartElement(Globals.list.ElementAt(0).ElementAt(j));
                    writer.WriteString(Globals.list.ElementAt(i).ElementAt(j));
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

        }
        //////////////////////////////////////////////////////////////////////////////
        public static void setDefaultValue(int j, string defaultValue)

        {

            for (int i = 0; i < Globals.rowsSize; i++)

            {

                if (Globals.list[i][j] == "Ǝ")

                {

                    Globals.list[i][j] = defaultValue;

                }

            }

        }
        //////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////






        public static void isNotNull(int j)

        {

            for (int i = 0; i < Globals.rowsSize; i++)

            {

                if (Globals.list[i][j] == "Ǝ")

                {

                    getData applyInvalidConstraint = new getData("Null value detected. Please enter a valid value" , "null", i, j);
                    applyInvalidConstraint.Show();
                    
                }

            }

        }



        //////////////////////////////////////////////////////////////////////////////



        public static void isUnique(int j)

        {

            for (int i = 0; i < Globals.rowsSize; i++)

            {

                string temp = Globals.list[i][j];

                for (int ii = i + 1; ii < Globals.rowsSize; ii++)

                {

                    if (list[ii][j] == temp)

                    {
                        
                        getData applyInvalidConstraint = new getData("Repeated value detected. Please enter a unique value", list[ii][j], i, j);
                        applyInvalidConstraint.Show();

                    }

                }

            }

        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        public static void isMoreThan(int j, float value, bool ints)

        {

            if (ints == true)

            {

                for (int i = 1; i < Globals.rowsSize; i++)

                {

                    if (float.Parse(Globals.list[i][j]) <= value)

                    {

                        getData applyInvalidConstraint = new getData("Value is NOT greater than " + value.ToString() + ". Please enter a valid value.", Globals.list[i][j], i, j);
                        applyInvalidConstraint.Show();

                    }

                }

            }

            else

            {

                for (int i = 1; i < Globals.rowsSize; i++)

                {

                    if (Globals.list[i][j].Length <= value)

                    {
                        getData applyInvalidConstraint = new getData("Value length is NOT greater than " + value.ToString() + ". Please enter a valid value.", Globals.list[i][j], i, j);
                        applyInvalidConstraint.Show();
                    }

                }

            }

        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        public static void isMoreThanOREqual(int j, float value, bool ints)

        {

            if (ints == true)

            {

                for (int i = 1; i < Globals.rowsSize; i++)

                {

                    if (float.Parse(Globals.list[i][j]) < value)

                    {
                        getData applyInvalidConstraint = new getData("Value is NOT greater than NOR equal " + value.ToString() + ". Please enter a valid value.", Globals.list[i][j], i, j);
                        applyInvalidConstraint.Show();
                    }

                }

            }

            else

            {

                for (int i = 1; i < Globals.rowsSize; i++)

                {

                    if (Globals.list[i][j].Length < value)

                    {

                        getData applyInvalidConstraint = new getData("Value length is NOT greater than NOR equal " + value.ToString() + ". Please enter a valid value.", Globals.list[i][j], i, j);
                        applyInvalidConstraint.Show();

                    }

                }

            }

        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        public static void isLessThan(int j, float value, bool ints)

        {

            if (ints == true)

            {

                for (int i = 1; i < Globals.rowsSize; i++)

                {

                    if (float.Parse(Globals.list[i][j]) >= value)

                    {
                        getData applyInvalidConstraint = new getData("Value is NOT less than " + value.ToString() + ". Please enter a valid value.", Globals.list[i][j], i, j);
                        applyInvalidConstraint.Show();
                    }

                }

            }

            else

            {

                for (int i = 1; i < Globals.rowsSize; i++)

                {

                    if (Globals.list[i][j].Length >= value)

                    {

                        getData applyInvalidConstraint = new getData("Value length is NOT less than " + value.ToString() + ". Please enter a valid value.", Globals.list[i][j], i, j);
                        applyInvalidConstraint.Show();

                    }

                }

            }

        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        public static void isLessThanOREqual(int j, float value, bool ints)

        {

            if (ints == true)

            {

                for (int i = 1; i < Globals.rowsSize; i++)

                {

                    if (float.Parse(Globals.list[i][j]) > value)

                    {
                        getData applyInvalidConstraint = new getData("Value is NOT less than NOR equal " + value.ToString() + ". Please enter a valid value.", Globals.list[i][j], i, j);
                        applyInvalidConstraint.Show();
                    }

                }

            }

            else

            {

                for (int i = 1; i < Globals.rowsSize; i++)

                {

                    if (Globals.list[i][j].Length > value)

                    {
                        getData applyInvalidConstraint = new getData("Value length is NOT less than NOR equal " + value.ToString() + ". Please enter a valid value.", Globals.list[i][j], i, j);
                        applyInvalidConstraint.Show();
                    }

                }

            }

        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        public static void isEqual(int j, float value, bool ints)

        {

            if (ints == true)

            {

                for (int i = 1; i < Globals.rowsSize; i++)

                {

                    if (float.Parse(Globals.list[i][j]) != value)

                    {
                        Globals.list[i][j] = value.ToString();
                        MessageBox.Show("The value is NOT equal " + value.ToString() + ". The value was automatically set to the given constraint.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }

            }

            else

            {

                for (int i = 1; i < Globals.rowsSize; i++)

                {

                    if (Globals.list[i][j].Length != value)

                    {

                        getData applyInvalidConstraint = new getData("Value length is NOT equal " + value.ToString() + ". Please enter a valid value.", Globals.list[i][j], i, j);
                        applyInvalidConstraint.Show();

                    }

                }

            }

        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        public static void isNOTEqual(int j, float value, bool ints)

        {

            if (ints == true)

            {

                for (int i = 1; i < Globals.rowsSize; i++)

                {

                    if (float.Parse(Globals.list[i][j]) == value)

                    {

                        getData applyInvalidConstraint = new getData("Value is equal to " + value.ToString() + ". Please enter a valid value.", Globals.list[i][j], i, j);
                        applyInvalidConstraint.Show();

                    }

                }

            }

            else

            {

                for (int i = 1; i < Globals.rowsSize; i++)

                {

                    if (Globals.list[i][j].Length == value)

                    {
                        getData applyInvalidConstraint = new getData("Value length is equal to " + value.ToString() + ". Please enter a valid value.", Globals.list[i][j], i, j);
                        applyInvalidConstraint.Show();
                    }

                }

            }

        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////






    }
}
