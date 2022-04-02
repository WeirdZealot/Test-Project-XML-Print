using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Windows.Xps.Packaging;
using System.IO;

namespace Test_Project_XML_Print
{
    /// <summary>
    /// Логика взаимодействия для DocViewer.xaml
    /// </summary>
    public partial class DocViewer : UserControl
    {
        public DocViewer()
        {
            InitializeComponent();
        }
        public void GetDocument(string path)
        {
            var tempcheck = File.Exists(@"/tempor.txt");
            if (tempcheck==true)
            {
                File.Delete(@"/tempor.txt");
            }
            XmlDataProvider provider = new XmlDataProvider();
            path = System.IO.Path.GetFullPath(path);
            provider.Source = new Uri (path);
            File.Create(@"/tempor.text");
            XmlDocument doc = new XmlDocument();
                doc.Load(path);
            using (StreamReader reader=new StreamReader(path))
                while (!reader.EndOfStream)
                {
                    string s = reader.ReadLine();
                    using (StreamWriter writer = new StreamWriter(@".\tempor.txt"))
                        writer.WriteLine(s);
                }
            var temppath = System.IO.Path.GetFullPath(@".\tempor.txt");
            Uri Uritemppath = new Uri(temppath);
            browser.Navigate(Uritemppath);
            
        }
    }
}
