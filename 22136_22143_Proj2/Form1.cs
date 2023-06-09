using System;
using System.Collections;
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

        // quando o formulário for carregado, será feita a leitura
        // dos arquivos necessários para o programa funcionar
        private void Form1_Load(object sender, EventArgs e)
        {
            if(dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    listaCidades = new ListaDupla<Cidade>();
                    listaCidades.LerDados(dlgAbrir.FileName);
                    pbMapa.Invalidate();

                    listaCidades.SituacaoAtual = Situacao.navegando;
                    listaCidades.PosicionarNoPrimeiro();
                    AtualizarTela();
                    lsbArquivo.Items.Add("Nome".PadRight(15, ' ') + " " + "X".PadLeft(6, ' ') + "Y".PadLeft(6, ' '));
                    listaCidades.ExibirDados(lsbArquivo);
                }
                catch(Exception)
                {
                    MessageBox.Show("Erro de leitura no arquivo.");
                }
            }
        }

        // no picturebox, assim que o arquivo solicitado for aberto
        // serão desenhadas as cidades descritas no mesmo (sobrescrevendo
        // a imagem do mapa)
        private void pbMapa_Paint(object sender, PaintEventArgs e)
        {
            if (listaCidades != null)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Black, 2);
                Brush brush = new SolidBrush(Color.LightGray);
                Brush brush2 = new SolidBrush(Color.Black);
                Font fonte = new Font("Arial", 10);

                int posicaoAtual = listaCidades.PosicaoAtual;
                listaCidades.PosicionarNoPrimeiro();

                while (listaCidades.DadoAtual() != null)
                {
                    Cidade cidade = listaCidades.DadoAtual();
                    g.DrawEllipse(pen, (float)cidade.X * pbMapa.Width - 5, (float)cidade.Y * pbMapa.Height - 5, 10, 10);
                    g.FillEllipse(brush, (float)cidade.X * pbMapa.Width - 4, (float)cidade.Y * pbMapa.Height - 4, 8, 8);
                    g.DrawString(cidade.Nome, fonte, brush2, (float)cidade.X * pbMapa.Width - 8, (float)cidade.Y * pbMapa.Height + 6);
                    listaCidades.AvancarPosicao();
                }
                listaCidades.PosicionarEm(posicaoAtual);
            }
        }

        // atualiza a tela de acordo com a dituação em que o usuário definindo como os botões
        // ficarão (por meio do método TestarBotoes, a mensagem que aparecerá no statusStrip para
        // auxiliar o usuário e os campos que precisarão ser limpos para que o usuário digite
        void AtualizarTela()
        {
            switch(listaCidades.SituacaoAtual)
            {
                case Situacao.navegando:
                    {
                        Cidade cidadeAtual = listaCidades.DadoAtual();
                        TestarBotoes();

                        if (cidadeAtual != null)
                        {
                            txtNome.Text = cidadeAtual.Nome;
                            nudX.Value = (decimal)cidadeAtual.X;
                            nudY.Value = (decimal)cidadeAtual.Y;
                            stRegistro.Items[0].Text = $"Registro: {listaCidades.PosicaoAtual + 1} / {listaCidades.Tamanho}";
                        }
                    }
                    break;

                case Situacao.pesquisando:
                    {
                        TestarBotoes();

                        txtNome.Text = "";
                        nudX.Value = 0;
                        nudY.Value = 0;

                        txtNome.Focus();
                        stRegistro.Items[0].Text = "Mensagem: Digite o nome da cidade que deseja procurar e depois clique em salvar";
                    }
                    break;

                case Situacao.incluindo:
                    {
                        TestarBotoes();

                        txtNome.Text = "";
                        nudX.Value = 0;
                        nudY.Value = 0;

                        txtNome.Focus();
                        stRegistro.Items[0].Text = "Mensagem: Informe o nome da cidade, clique na posição do mapa onde deseja incluir e depois clique em salvar";
                    }
                    break;
            }
        }

        // indica quais botões poderão ser habilitados de acordo
        // coma situação em que o usuário se encontra no programa
        void TestarBotoes()
        {
            switch (listaCidades.SituacaoAtual)
            {
                case Situacao.navegando:
                    {
                        btnAnterior.Enabled = true;
                        btnInicio.Enabled   = true;
                        btnProximo.Enabled  = true;
                        btnUltimo.Enabled   = true;
                        btnProcurar.Enabled = true;
                        btnNovo.Enabled     = true;
                        btnSalvar.Enabled   = true;
                        btnExcluir.Enabled  = true;

                        if (listaCidades.EstaNoInicio)
                        {
                            btnAnterior.Enabled = false;
                            btnInicio.Enabled   = false;
                        }

                        if (listaCidades.EstaNoFim)
                        {
                            btnProximo.Enabled = false;
                            btnUltimo.Enabled  = false;
                        }
                    }
                    break;

                case Situacao.pesquisando:
                    {
                        btnAnterior.Enabled  = false;
                        btnInicio.Enabled    = false;
                        btnProximo.Enabled   = false;
                        btnUltimo.Enabled    = false;
                        btnNovo.Enabled      = false;
                        btnExcluir.Enabled   = false;
                    }
                    break;

                case Situacao.incluindo:
                    {
                        btnAnterior.Enabled = false;
                        btnInicio.Enabled   = false;
                        btnProximo.Enabled  = false;
                        btnUltimo.Enabled   = false;
                        btnProcurar.Enabled = false;
                        btnExcluir.Enabled  = false;
                    }
                    break;
            }
        }

        // a partir daqui, o que será apresentado no código é o que cada
        // botão faz ao ser clicado pelo usuário, cada um realizando as suas
        // respectivas funções
        private void btnProximo_Click(object sender, EventArgs e)
        {
            listaCidades.AvancarPosicao();
            AtualizarTela();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            listaCidades.RetrocederPosicao();
            AtualizarTela();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            listaCidades.PosicionarNoPrimeiro();
            AtualizarTela();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            listaCidades.PosicionarNoUltimo();
            AtualizarTela();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            listaCidades.SituacaoAtual = Situacao.pesquisando;
            AtualizarTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch(listaCidades.SituacaoAtual)
            {
                case Situacao.navegando:
                    {
                        // mostrará a tela para que o usuário salve o arquivo
                        if (dlgSalvar.ShowDialog() == DialogResult.OK)
                        {
                            listaCidades.GravarDados(dlgSalvar.FileName);
                        }
                    }
                    break;

                case Situacao.pesquisando:
                    {
                        // se a situação for pesquisando, será preciso ver se aquela cidade existe
                        // para que quando o usuário clique no botão de salvar, as respectivas informações
                        // daquela cidade apareçam nos devidos campos
                        if (listaCidades.Existe(new Cidade(txtNome.Text, 0, 0), out int ondeEsta))
                        {
                            listaCidades.SituacaoAtual = Situacao.navegando;
                            AtualizarTela();
                        }
                        else
                        {
                            MessageBox.Show("A cidade procurada não está registrada!");
                        }
                    }
                    break;

                case Situacao.incluindo:
                    {
                        // se a situação for de inclusão, incluirei uma nova cidade com as informações digitadas 
                        // nos devidos campos pelo usuário
                        if (listaCidades.Incluir(new Cidade(txtNome.Text, (double)nudX.Value, (double)nudY.Value)))
                        {
                            listaCidades.SituacaoAtual = Situacao.navegando;
                            AtualizarTela();
                            listaCidades.ExibirDados(lsbArquivo);
                            pbMapa.Invalidate();
                        }
                        else
                        {
                            MessageBox.Show("A cidade que deseja incluir já está registrada!");
                        }
                    }
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            listaCidades.SituacaoAtual = Situacao.navegando;
            AtualizarTela();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            listaCidades.SituacaoAtual = Situacao.incluindo;
            AtualizarTela();
        }

        private void pbMapa_MouseClick(object sender, MouseEventArgs e)
        {
            if (listaCidades.SituacaoAtual == Situacao.incluindo)
            {
                //depois ver como mudar cursor para incluir cidades
                nudX.Value = (decimal) e.X / pbMapa.Width;
                nudY.Value = (decimal) e.Y / pbMapa.Height;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você deseja excluir esse registro permanentemente?",
                                "Deseja Excluir?",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listaCidades.SituacaoAtual = Situacao.excluindo;
                listaCidades.ExcluirAtual();
                listaCidades.SituacaoAtual = Situacao.navegando;
                AtualizarTela();
                pbMapa.Invalidate();
                listaCidades.ExibirDados(lsbArquivo);
            }
        }

        // não permitir que o usuário saia do programa sem salvar as alterações que
        // o mesmo fez em seu arquivo durante a utilização do programa
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja salvar antes de sair?",
                                "Deseja salvar?",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dlgSalvar.ShowDialog() == DialogResult.OK)
                {
                    listaCidades.GravarDados(dlgSalvar.FileName);
                }
            }

            this.Close();
        }
    }
}
