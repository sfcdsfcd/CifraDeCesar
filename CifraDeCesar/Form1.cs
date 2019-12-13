using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CifraDeCesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCript_Click(object sender, EventArgs e)
        {
            Txt_ResultadoCRIPT.Text = String.Empty;
            var Palavras = TxtMensagemCript.Text.Split(' ');

            foreach (string txt in Palavras)
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    int TabelaASCII = (int)txt[i];

                    for (int cont = 0; cont < int.Parse(TxtChaveCript.Text); ++cont)
                    {

                        TabelaASCII = TabelaASCII < 122 ? TabelaASCII + 1 : 97;

                    }

                    Txt_ResultadoCRIPT.Text += Char.ConvertFromUtf32(TabelaASCII);

                }
                Txt_ResultadoCRIPT.Text += " ";
            }


            Txt_ResultadoCRIPT.Text = Txt_ResultadoCRIPT.Text.Trim();

        }

        private void BtnDECRIPT_Click(object sender, EventArgs e)
        {
            Txt_ResultadoDECRIPT.Text = String.Empty;

            var Palavras = TxtMensagemDECript.Text.Split(' ');

            foreach (string txt in Palavras)
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    int TabelaASCII = (int)txt[i];

                    for (int cont = 0; cont < int.Parse(TxtChaveDECRIPT.Text); ++cont)
                    {

                        TabelaASCII = TabelaASCII > 97 ? TabelaASCII - 1 : 122;

                    }

                    Txt_ResultadoDECRIPT.Text += Char.ConvertFromUtf32(TabelaASCII);
                }
                Txt_ResultadoDECRIPT.Text += " ";
            }
            Txt_ResultadoCRIPT.Text = Txt_ResultadoCRIPT.Text.Trim();


        }
    }
}
