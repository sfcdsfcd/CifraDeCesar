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

            for (int i = 0; i < TxtMensagemCript.Text.Length; i++)
            {
                int TabelaASCII = (int)TxtMensagemCript.Text[i];
                int CriptoGrafado = TabelaASCII + Byte.Parse(TxtChaveCript.Text);
                


                Txt_ResultadoCRIPT.Text += Char.ConvertFromUtf32(CriptoGrafado);
                
            }

        }

        private void BtnDECRIPT_Click(object sender, EventArgs e)
        {
            Txt_ResultadoDECRIPT.Text = String.Empty;

            for (int i = 0; i < TxtMensagemDECript.Text.Length; i++)
            {
                int TabelaASCII = (int)TxtMensagemDECript.Text[i];
                int CriptoGrafado = TabelaASCII - Byte.Parse(TxtChaveDECRIPT.Text);



                Txt_ResultadoDECRIPT.Text += Char.ConvertFromUtf32(CriptoGrafado);

            }
        }
    }
}
