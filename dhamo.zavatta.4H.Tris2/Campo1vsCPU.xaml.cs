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
using System.Windows.Shapes;

namespace dhamo.zavatta._4H.Tris2
{
    /// <summary>
    /// Logica di interazione per Campo1vsCPU.xaml
    /// </summary>
    public partial class Campo1vsCPU : Window
    {
        Tris var = new Tris();
        int Conta1 = 0, Conta2 = 0, contaCasellePiene = 0;

        public Campo1vsCPU()
        {
            InitializeComponent();
        }

        public void Computer()
        {
            if (contaCasellePiene < 9)
            {
                contaCasellePiene++;
                int[] coordinate = var.MossaComputer();
                if (coordinate[0] == 0 && coordinate[1] == 0)
                {
                    btn1.Content = var.Mossa(coordinate[0], coordinate[1]);
                }
                else if (coordinate[0] == 0 && coordinate[1] == 1)
                {
                    btn2.Content = var.Mossa(coordinate[0], coordinate[1]);
                }
                else if (coordinate[0] == 0 && coordinate[1] == 2)
                {
                    btn3.Content = var.Mossa(coordinate[0], coordinate[1]);
                }
                else if (coordinate[0] == 1 && coordinate[1] == 0)
                {
                    btn4.Content = var.Mossa(coordinate[0], coordinate[1]);
                }
                else if (coordinate[0] == 1 && coordinate[1] == 1)
                {
                    btn5.Content = var.Mossa(coordinate[0], coordinate[1]);
                }
                else if (coordinate[0] == 1 && coordinate[1] == 2)
                {
                    btn6.Content = var.Mossa(coordinate[0], coordinate[1]);
                }
                else if (coordinate[0] == 2 && coordinate[1] == 0)
                {
                    btn7.Content = var.Mossa(coordinate[0], coordinate[1]);
                }
                else if (coordinate[0] == 2 && coordinate[1] == 1)
                {
                    btn8.Content = var.Mossa(coordinate[0], coordinate[1]);
                }
                else if (coordinate[0] == 2 && coordinate[1] == 2)
                {
                    btn9.Content = var.Mossa(coordinate[0], coordinate[1]);
                }
            }
        }

        private void VerificaVittoria()
        {
            if (var.Vittoria() == 0)
            {
                MessageBox.Show($"HAI VINTO, COMPLIMENTI");
                Resetta();
                Conta1++;
                G1.Content = Conta1.ToString();
            }
            else if (var.Vittoria() == 1)
            {
                MessageBox.Show($"HAI PERSO, RIPROVA");
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
                contaCasellePiene++;
                Computer();
            }

            VerificaVittoria();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (btn2.Content == null)
            {
                btn2.Content = var.Mossa(0, 1);
                contaCasellePiene++;
                Computer();
            }
            VerificaVittoria();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (btn3.Content == null)
            {
                btn3.Content = var.Mossa(0, 2);
                contaCasellePiene++;
                Computer();
            }

            VerificaVittoria();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (btn4.Content == null)
            {
                btn4.Content = var.Mossa(1, 0);
                contaCasellePiene++;
                Computer();
            }

            VerificaVittoria();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (btn5.Content == null)
            {
                btn5.Content = var.Mossa(1, 1);
                contaCasellePiene++;
                Computer();
            }

            VerificaVittoria();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (btn6.Content == null)
            {
                btn6.Content = var.Mossa(1, 2);
                contaCasellePiene++;
                Computer();
            }

            VerificaVittoria();
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (btn7.Content == null)
            {
                btn7.Content = var.Mossa(2, 0);
                contaCasellePiene++;
                Computer();
            }

            VerificaVittoria();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (btn8.Content == null)
            {
                btn8.Content = var.Mossa(2, 1);
                contaCasellePiene++;
                Computer();
            }

            VerificaVittoria();
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (btn9.Content == null)
            {
                btn9.Content = var.Mossa(2, 2);
                contaCasellePiene++;
                Computer();
            }

            VerificaVittoria();
        }

        public void Resetta()
        {
            var = new Tris();
            contaCasellePiene = 0;
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
