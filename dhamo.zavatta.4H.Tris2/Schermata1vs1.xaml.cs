using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace dhamo.zavatta._4H.Tris2
{
    /// <summary>
    /// Logica di interazione per Schermata1vs1.xaml
    /// </summary>
    public partial class Schermata1vs1 : Window
    {
        public Schermata1vs1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (g1.Text == "" || g2.Text == "")
            {
                MessageBox.Show("Devi riempire tutti i campi");
            }
            else
            {
                StreamWriter add = new StreamWriter("salva.txt");
                add.Write($"{g1.Text};{g2.Text}");
                add.Close();
                Campo1vs1 Finestra = new Campo1vs1();
                Finestra.ShowDialog();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
