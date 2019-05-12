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

        public static string Data;

        public static string[] records;

        public static List<List<String>> list;

        public static int rowsSize;
//////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////
        public static void Null()

        {

            for (int i = 0; i < Data.Length - 1; i++)

            {

                if (Data[i] == columDelimiter && Data[i + 1] == columDelimiter)

                    Data.Insert(i + 1, "Ǝ");

            }

        }
        //////////////////////////////////////////////////////////////////////////////
        public static void getExcel()

        {

            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile workbook = ExcelFile.Load(xlsxFileName);

            ExcelWorksheet worksheet = workbook.Worksheets.ActiveWorksheet;



            CellRange range = worksheet.GetUsedCellRange(true);



            for (int r = range.FirstRowIndex; r <= range.LastRowIndex; r++)

            {

                List<String> tempList = new List<string>();



                for (int c = range.FirstColumnIndex; c <= range.LastColumnIndex; c++)

                {

                    ExcelCell cell = range[r - range.FirstRowIndex, c - range.FirstColumnIndex];



                    //string cellName = CellRange.RowColumnToPosition(r, c);

                    //string cellRow = ExcelRowCollection.RowIndexToName(r);

                    //string cellColumn = ExcelColumnCollection.ColumnIndexToName(c);



                    if (string.IsNullOrEmpty(cell.Value.ToString()))

                    {

                        tempList.Add("Ǝ");

                    }
                    else
                    {

                        tempList.Add(cell.StringValue);

                    }

                }



                list.Add(tempList);



            }



        }
        //////////////////////////////////////////////////////////////////////////////
        public static void getText()

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
        //////////////////////////////////////////////////////////////////////////////
        public static void setXML()

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
        //////////////////////////////////////////////////////////////////////////////
        public static void setDefaultValue(int j, string defaultValue)

        {

            for (int i = 0; i < rowsSize; i++)

            {

                if (list[i][j] == "Ǝ")

                {

                    list[i][j] = defaultValue;

                }

            }

        }
        //////////////////////////////////////////////////////////////////////////////
        public static bool isNotNull(int j)

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
        //////////////////////////////////////////////////////////////////////////////
        public static bool isUnique(int j)

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
        public static bool isGreaterThan(int j, int value, bool ints)

        {

            if (ints == true)

            {

                for (int i = 0; i < rowsSize; i++)

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
        public static bool isGreaterThanOrEqual(int j, int value, bool ints)

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
        public static bool isLessThan(int j, int value, bool ints)

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
        public static bool isLessThanOrEqual(int j, int value, bool ints)

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
        public static bool isEqual(int j, int value, bool ints)

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
        public static bool isNotEqual(int j, int value, bool ints)

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
    }
}
