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
using System.Xml.Linq;
using System.IO;
using System.Drawing.Printing;
using Awesomium.Windows.Controls;
using Awesomium.Windows.Data;
using Awesomium.Windows.Forms;


namespace Test_Project_XML_Print
{
    public partial class PrintForm : Form
    {


        public PrintForm()
        {
            InitializeComponent();
            var check = File.Exists(@".\table.xml");
            if (check == false)
                File.Create(@".\table.xml");
            else
            {
                File.Delete(@".\table.xml");
                File.Create(@".\table.xml");
            }
            var xmlcheck = File.Exists(@".\test.xml");
            if (xmlcheck == true)
            {
                File.Delete(@".\test.xml");
            }
            else
            {
                File.Create(@".\test.xml");
            }


        }
        DataTable datatable = new DataTable();
        List<string> TextboxList = new List<string>();
        string selectedfile = "";





        private void SelectColumn_Click(object sender, EventArgs e)
        {
            datatable.Columns.Add(NewName.ToString());
            SBind.DataSource = datatable;
            TableView.DataSource = SBind;
            TableView.Refresh();
        }
        XElement root = new XElement("root");
        XDocument xdoc = new XDocument();
        bool hasroot = false;
        private void setdoc()
        {
            if (hasroot == false)
            {
                xdoc.Add(root);
                hasroot = true;
            }
        }



        private void SelectRow_Click(object sender, EventArgs e)
        {
            datatable.Rows.Add(NewName.ToString());
            SBind.DataSource = datatable;
            TableView.DataSource = SBind;
            TableView.Refresh();
        }
        /*public DataTable writetable()
        {
            DataTable datatable=new DataTable(tableName:"mytable");
            var row_count = TableView.Rows.Count;
            var column_count = TableView.Columns.Count;
            string[] columns_name = new string[column_count];
            string[] rows_values = new string[row_count];
            string[,] values = new string[column_count, row_count];
            foreach (DataGridViewColumn column in TableView.Columns)
                datatable.Columns.Add(column.HeaderText, column.ValueType);
            foreach (DataGridViewRow row in TableView.Rows)
            {
                datatable.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                    datatable.Rows[datatable.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
            }
            StringBuilder style_begin = new StringBuilder();
            style_begin.Append("<?xml version=\"1.0\" encoding=\"UTF - 8\"?> \n");
            style_begin.Append("<xsl:stylesheet version=\"1.0\" xmlns:xsl=\"http://www.w3.org/TR/WD-xsl\"> \n");
            style_begin.Append("<xsl:template match=\" / \"> \n");
            style_begin.Append("<table border=\"1\"> \n");
            style_begin.Append("<tr bgcolor=\"#CCCCCC\"> \n");
            for (int i = 0; i <= datatable.Columns.Count - 1; i++)
            {
                style_begin.Append("<td align=\"center\"><strong>" + datatable.Columns[i].ColumnName + "</strong></td> \n");
            }
            style_begin.Append("<xsl:for-each select=\"root/mytable\"");
            style_begin.Append("< tr bgcolor = \"#F5F5F5\" >");
            for (int i = 0; i <= datatable.Columns.Count - 1; i++)
            {
                style_begin.Append("<td><xsl:value-of select=" + datatable.Columns[i].ColumnName + "/></td> \n");
            }
            style_begin.Append("</tr> \n");
            style_begin.Append("</xsl:for-each> \n");
            style_begin.Append("</table> \n");
            style_begin.Append("</xsl:template>\n");
            style_begin.Append("</xsl:stylesheet>\n");
            File.WriteAllText(@".\style.xsl", style_begin.ToString());
            return datatable;
            
        }*/



        public void CreateXML_Click(object sender, EventArgs e)
        {


            var row_count = TableView.Rows.Count;
            var column_count = TableView.Columns.Count;
            DataTable DataToXML = new DataTable(tableName: "mytable");
            string[] columns_name = new string[column_count];
            string[] rows_values = new string[row_count];
            string[,] values = new string[column_count, row_count];


            foreach (DataGridViewColumn column in TableView.Columns)
                DataToXML.Columns.Add(column.HeaderText, column.ValueType);
            foreach (DataGridViewRow row in TableView.Rows)
            {
                DataToXML.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                    DataToXML.Rows[DataToXML.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
            }
            if (File.Exists((@".\style.xsl")) == true)
                File.Delete(@".\style.xsl");



            setdoc();



            string stylepath = System.IO.Path.GetFullPath(@".\style.xml");

            XProcessingInstruction proc = new XProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" ref=\"" + stylepath + "\"");

            if (textBox1.Text.Length != 0)
            {
                XElement textbox1 = new XElement("content", textBox1.Text);
                root.Add(textbox1);
            }
            if (textBox2.Text.Length != 0)
            {
                XElement textbox2 = new XElement("content", textBox2.Text);
                root.Add(textbox2);
            }
            if (textBox3.Text.Length != 0)
            {
                XElement textbox3 = new XElement("content", textBox3.Text);
                root.Add(textbox3);
            }
            if (textBox4.Text.Length != 0)
            {
                XElement textbox4 = new XElement("content", textBox4.Text);
                root.Add(textbox4);
            }
            if (textBox5.Text.Length != 0)
            {
                XElement textbox5 = new XElement("content", textBox5.Text);
                root.Add(textbox5);
            }
            if (textBox6.Text.Length != 0)
            {
                XElement textbox6 = new XElement("content", textBox6.Text);
                root.Add(textbox6);
            }
            if (textBox7.Text.Length != 0)
            {
                XElement textbox7 = new XElement("content", textBox7.Text);
                root.Add(textbox7);
            }
            if (textBox8.Text.Length != 0)
            {
                XElement textbox8 = new XElement("content", textBox8.Text);
                root.Add(textbox8);
            }
            if (textBox9.Text.Length != 0)
            {
                XElement textbox9 = new XElement("content", textBox9.Text);
                root.Add(textbox9);
            }
            if (textBox10.Text.Length != 0)
            {
                XElement textbox10 = new XElement("content", textBox10.Text);
                root.Add(textbox10);
            }


            xdoc.Save(@".\test.xml");

            XElement mytable = new XElement("mytable");

            for (int i = 0; i <= DataToXML.Columns.Count - 1; i++)
            {

                XElement column = new XElement(DataToXML.Columns[i].ColumnName);



                for (int j = 0; j <= DataToXML.Rows.Count - 1; j++)
                {
                    XElement row = new XElement("row" + j);

                    row.Add(DataToXML.Rows[j][i]);
                    column.Add(row);

                }
                mytable.Add(column);

            }
            root.Add(mytable);
            StringBuilder style_begin = new StringBuilder();
            style_begin.Append("<?xml version=\"1.0\" encoding=\"UTF - 8\"?> \n");
            style_begin.Append("<xsl:stylesheet version=\"1.0\" xmlns:xsl=\"http://www.w3.org/TR/WD-xsl\"> \n");
            style_begin.Append("<xsl:template match=\" / \"> \n");
            style_begin.Append("<table border=\"1\"> \n");
            style_begin.Append("<tr bgcolor=\"#CCCCCC\"> \n");
            for (int i = 0; i <= DataToXML.Columns.Count - 1; i++)
            {
                style_begin.Append("<td align=\"center\"><strong>" + DataToXML.Columns[i].ColumnName + "</strong></td> \n");
            }
            style_begin.Append("<xsl:for-each select=\"root/mytable\"");
            style_begin.Append("< tr bgcolor = \"#F5F5F5\" >");
            for (int i = 0; i <= DataToXML.Columns.Count - 1; i++)
            {
                style_begin.Append("<td><xsl:value-of select=" + DataToXML.Columns[i].ColumnName + "/></td> \n");
            }
            style_begin.Append("</tr> \n");
            style_begin.Append("</xsl:for-each> \n");
            style_begin.Append("</table> \n");
            style_begin.Append("</xsl:template>\n");
            style_begin.Append("</xsl:stylesheet>\n");
            File.WriteAllText(@".\style.xsl", style_begin.ToString());


            xdoc.Save(@".\test.xml");
            string absolute = System.IO.Path.GetFullPath(@".\test.xml");

            Awesomium.Source = new Uri(absolute);


        }

        private void PrintDoc_Click(object sender, EventArgs e)
        {
            string printing;
            string filename = @".\test.xml";
            PrintDialog printDialog = new PrintDialog();
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            printDialog.AllowSelection = true;
            printDialog.ShowDialog();

            PrintDocument pd = new PrintDocument();
            using (FileStream stream = new FileStream(filename, FileMode.Open))
            using (StreamReader redaer = new StreamReader(stream))
            {
                printing = redaer.ReadToEnd();
            }
            pd.Print();
        }

        private void FiletoXML_Click(object sender, EventArgs e)
        {
            setdoc();
            /* var selectedfile;*/
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            openFileDialog.Title = "Select file for XML";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedfilepath = openFileDialog.FileName;


                Byte[] bytes = File.ReadAllBytes(selectedfilepath);

                string encode = Convert.ToBase64String(bytes);
                XElement base64 = new XElement("application", encode);

                root.Add(base64);
                xdoc.Save(@"./test.xml");
                string absolute = System.IO.Path.GetFullPath(@".\test.xml");
                Awesomium.Source = new Uri(absolute);
            }
        }

        private void DeleteColumn_Click(object sender, EventArgs e)
        {
            var selected_index = TableView.CurrentCell.ColumnIndex;
            datatable.Columns.RemoveAt(selected_index);
            SBind.DataSource = datatable;
            TableView.DataSource = SBind;
            TableView.Refresh();
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            var selected_index = TableView.CurrentCell.ColumnIndex;
            datatable.Rows.RemoveAt(selected_index);
            SBind.DataSource = datatable;
            TableView.DataSource = SBind;
            TableView.Refresh();
        }

    }
}
   