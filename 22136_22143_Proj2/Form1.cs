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

namespace _22136_22143_Proj2
{
    // Nome: Hugo Gomes Soares - RA: 22136
    // Nome: Maria Eduarda de Jesus Padovan - RA: 22143
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaDupla<Cidade> listaCidades;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    listaCidades = new ListaDupla<Cidade>();
                    listaCidades.LerDados(dlgAbrir.FileName);
                    pbMapa.Invalidate();
                }
                catch(IOException)
                {
                    MessageBox.Show("Erro de leitura no arquivo.");
                }
            }
        }

        private void pbMapa_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            listaCidades.PosicionarNoPrimeiro();
            while (listaCidades.DadoAtual() != null)
            {
                g.DrawEllipse(pen, (float) listaCidades.DadoAtual().X * pbMapa.Width, (float) listaCidades.DadoAtual().Y * pbMapa.Height, 3, 3);
                listaCidades.AvancarPosicao();
            }
        }
    }
}
