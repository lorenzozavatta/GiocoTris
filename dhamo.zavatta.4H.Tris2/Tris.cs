using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhamo.zavatta._4H.Tris2
{
    class Tris
    {
        int[,] campo = new int[3, 3];
        public int turno { get; set; }
        int[] coordinate = new int[2];
        int x = 0, y = 0;
        Random rdnX = new Random();
        Random rndY = new Random();

        public Tris()
        {
            turno = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    campo[i, j] = 0;
                }
            }
        }

        public string Mossa(int x, int y)
        {
            string simbolo = "";
            if (campo[x, y] == 0)
            {
                if (turno == 0)
                {
                    campo[x, y] = 1;
                    turno++;
                    simbolo = "X";
                }
                else if (turno == 1)
                {
                    campo[x, y] = 10;
                    turno--;
                    simbolo = "O";
                }
            }

            return simbolo;
        }

        public int[] MossaComputer()
        {

            while (campo[x, y] != 0)
            {
                x = rdnX.Next(0, 3);
                y = rdnX.Next(0, 3);
            }
            coordinate[0] = x;
            coordinate[1] = y;

            return coordinate;
        }

        
        public int Vittoria()
        {
            int contaOrr = 0;
            int contaCasellePiene = 0; //serve per il reset
            int contaVerticale = 0;
            int contaDiagonale1 = 0;
            int contaDiagonale2 = campo[2, 0] + campo[1, 1] + campo[0, 2];
            int vincitore = -1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (campo[i, j] != 0)
                    {
                        contaCasellePiene++;
                    }

                    contaOrr = contaOrr + campo[i, j];
                    contaVerticale = contaVerticale + campo[j, i];

                    if (i == j)
                    {

                        contaDiagonale1 = contaDiagonale1 + campo[i, j];

                    }
                }

                if (contaOrr == 3 || contaVerticale == 3 || contaDiagonale1 == 3 || contaDiagonale2 == 3)
                {
                    vincitore = 0;
                }
                else if (contaOrr == 30 || contaVerticale == 30 || contaDiagonale1 == 30 || contaDiagonale2 == 30)
                {
                    vincitore = 1;
                }
                else if (contaCasellePiene == 9)
                {
                    vincitore = 2;
                }

                contaOrr = 0;
                contaVerticale = 0;

            }
            return vincitore;
        }
    }
}
