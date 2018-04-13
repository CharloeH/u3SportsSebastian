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

namespace u3SportsSebsatian
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            string strNewsFeed = "";
            System.Net.WebClient NewsFeed = new System.Net.WebClient();
            System.IO.StreamReader streamReader = new System.IO.StreamReader(NewsFeed.OpenRead("http://www.cbc.ca/cmlink/rss-sports-nhl"));
            //System.IO.StreamWriter streamWriter = new System.IO.StreamWriter("teams.txt");
            try
            {
                int numberOfThings = 0;
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    if (line.Contains("<item"))
                    {
                        while (!line.Contains("</item>"))
                        {
                            if(line.Contains("toronto"))
                            {
                                txtInput = txtInput + "\r" + line;
                                //streamWriter.WriteLine(line);
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }
    }
}
