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
    /// Logica di interazione per Campo1vs1.xaml
    /// </summary>
    public partial class Campo1vs1 : Window
    {
        Tris var = new Tris();
        Giocatore q;
        int Conta1 = 0, Conta2 = 0;

        public Campo1vs1()
        {
            InitializeComponent();
            StreamReader leggi = new StreamReader("salva.txt");
            string riga = leggi.ReadLine();
            string[] g = riga.Split(';');
            q = new Giocatore(g[0], g[1]);
            giocatore1.Text = q.stpG1();
            giocatore2.Text = q.stpG2();
        }

        private void VerificaVittoria()
        {
            if (var.Vittoria() == 0)
            {
                MessageBox.Show($"HAI VINTO {giocatore1.Text}");
                Resetta();
                Conta1++;
                G1.Content = Conta1.ToString();
            }
            else if (var.Vittoria() == 1)
            {
                MessageBox.Show($"HAI VINTO {giocatore2.Text}");
                Resetta();
                Conta2++;
                G2.Content = Conta2.ToString();
            }
            else if (var.Vittoria() == 2)
            {
                Resetta();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (btn1.Content == null)
            {
                btn1.Content = var.Mossa(0, 0);
            }
            VerificaVittoria();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (btn2.Content == null)
            {
                btn2.Content = var.Mossa(0, 1);
            }
            VerificaVittoria();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (btn3.Content == null)
            {
                btn3.Content = var.Mossa(0, 2);
            }
            VerificaVittoria();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (btn4.Content == null)
            {
                btn4.Content = var.Mossa(1, 0);
            }
            VerificaVittoria();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (btn5.Content == null)
            {
                btn5.Content = var.Mossa(1, 1);
            }
            VerificaVittoria();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (btn6.Content == null)
            {
                btn6.Content = var.Mossa(1, 2);
            }
            VerificaVittoria();
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (btn7.Content == null)
            {
                btn7.Content = var.Mossa(2, 0);
            }
            VerificaVittoria();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (btn8.Content == null)
            {
                btn8.Content = var.Mossa(2, 1);
            }
            VerificaVittoria();
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (btn9.Content == null)
            {
                btn9.Content = var.Mossa(2, 2);
            }
            VerificaVittoria();
        }

        public void Resetta()
        {
            var = new Tris();
            btn1.Content = null;
            btn2.Content = null;
            btn3.Content = null;
            btn4.Content = null;
            btn5.Content = null;
            btn6.Content = null;
            btn7.Content = null;
            btn8.Content = null;
            btn9.Content = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

