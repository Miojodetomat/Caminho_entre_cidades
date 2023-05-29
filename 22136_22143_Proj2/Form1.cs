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
                catch(Exception)
                {
                    MessageBox.Show("Erro de leitura no arquivo.");
                }
            }
        }

        private void pbMapa_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.LightGray);
            Brush brush2 = new SolidBrush(Color.Black);
            Font fonte = new Font("Arial", 10);
            listaCidades.PosicionarNoPrimeiro();
            while (listaCidades.DadoAtual() != null)
            {
                Cidade cidade = listaCidades.DadoAtual();
                g.DrawEllipse(pen, (float) cidade.X * pbMapa.Width - 5, (float) cidade.Y * pbMapa.Height - 5, 10, 10);
                g.FillEllipse(brush, (float) cidade.X * pbMapa.Width - 4, (float) cidade.Y * pbMapa.Height - 4, 8, 8);
                g.DrawString(cidade.Nome, fonte, brush2, (float)cidade.X * pbMapa.Width - 8, (float)cidade.Y * pbMapa.Height + 6);
                listaCidades.AvancarPosicao();
            }
        }
    }
}
