using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorPlacasCinzas
{
    public partial class Frm_Conversor : Form
    {
        public Frm_Conversor()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Importar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Selecione um arquivo de texto";
            openFileDialog1.Filter = "Arquivos de texto (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = openFileDialog1.FileName;

                ConversorPlacasCinza conversor = new ConversorPlacasCinza();

                conversor.ConverterPlacas(caminhoArquivo);

                int numero = 100;
                Pgb_BarraDeProgresso.Visible = true;

                for (int i = 0; i < numero; i++)
                {
                    Pgb_BarraDeProgresso.Value = i;
                }

                Btn_Importar.Visible = false;
                Lbl_TextoAjuda.Visible = false;
                Lbl_Mensagem.Visible = true;
            } else
            {
                Lbl_Mensagem.Visible = true;
                Lbl_Mensagem.Text = "Erro na tentativa!";
            }
        }

        private void Btn_Reiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Frm_Conversor_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_Mensagem_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_TextoAjuda_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ajuda_Click(object sender, EventArgs e)
        {

        }
    }
}
