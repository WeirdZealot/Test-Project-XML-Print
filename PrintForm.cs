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

namespace Test_Project_XML_Print
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
            var check=File.Exists(@".\table.txt");
            if (check == false)
                File.Create(@".\table.txt");
            else
            {
                File.Delete(@".\table.txt");
                File.Create(@".\table.txt");
            }
            var xmlcheck = File.Exists(@"\test.xml");
            if (xmlcheck == true)
            {
                File.Delete((@"\test.xml"));
            }
        }
        DataTable datatable = new DataTable();
        List<string> TextboxList = new List<string>();
     

        private void SelectColumn_Click(object sender, EventArgs e)
        {
            datatable.Columns.Add(NewName.ToString());
            SBind.DataSource = datatable;
            TableView.DataSource = SBind;
            TableView.Refresh();
        }

        private void SelectRow_Click(object sender, EventArgs e)
        {
            datatable.Rows.Add(NewName.ToString());
            SBind.DataSource = datatable;
            TableView.DataSource = SBind;
            TableView.Refresh();
        }

        private void CreateXML_Click(object sender, EventArgs e)
        {
            
            TextboxList.Add(textBox1.Text);
            /* TextboxList.Add(textBox2.Text);
             TextboxList.Add(textBox3.Text);
             TextboxList.Add(textBox4.Text);
             TextboxList.Add(textBox5.Text);
             TextboxList.Add(textBox6.Text);
             TextboxList.Add(textBox7.Text);
             TextboxList.Add(textBox8.Text);
             TextboxList.Add(textBox9.Text);
             TextboxList.Add(textBox10.Text);*/
            var row_count=TableView.Rows.Count;
            var column_count = TableView.Columns.Count;
            DataTable DataToXML = new DataTable();
            string[] columns_name = new string[column_count];
            string[] rows_values = new string[row_count];
            string[,] values = new string[column_count, row_count];
            
            
            foreach (DataGridViewColumn column in TableView.Columns)
                DataToXML.Columns.Add(column.HeaderText, column.ValueType);
            foreach(DataGridViewRow row in TableView.Rows)
            {
                DataToXML.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                    DataToXML.Rows[DataToXML.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
            }


            XDocument xdoc = new XDocument();
            XElement root = new XElement("root");
            XElement textbox = new XElement("content",TextboxList[0]);
            root.Add(textbox);
            xdoc.Add(root);
            for (int i=0;i<=DataToXML.Columns.Count-1;i++)
            {
                XElement column = new XElement(DataToXML.Columns[i].ColumnName);
                for (int j=0;j<=DataToXML.Rows.Count-1;j++)
                {
                    XElement row = new XElement("row_" + j);

                    row.Add(DataToXML.Rows[j][i]);
                    column.Add(row);
                }
                
                root.Add(column);
            }

            
            
            
             /*DataToXML.WriteXml(@".\test.xml");*/ //записывает только в отдельный файл, по заданию нужно записывать всё в один//
             xdoc.Save(@".\test.xml");
            DocViewer doc = new DocViewer();
            doc.GetDocument(@".\test.xml");
            elementHost1.Show();
            
        }

        
    }

}
