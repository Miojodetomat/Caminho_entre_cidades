﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using apArvore1;

namespace _22136_22143_Proj1ED
{
    // Nome: Hugo Gomes Soares - RA: 22136
    // Nome: Maria Eduarda de Jesus Padovan - RA: 22143

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum Situacao
        {
            navegando, excluindo, incluindo, pesquisando, editando
        }

        //ListaDupla<Ligacao> listaLigacoes;
        Arvore<Cidade> arvoreCidades;
        Situacao situacaoAtual;
        /*Ligacao[,] matrizDeAdjacencia;
        List<PilhaVetor<Ligacao>> caminhos;*/

        // quando o formulário for carregado, será feita a leitura
        // dos arquivos necessários para o programa funcionar
        private void Form1_Load(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    arvoreCidades = new Arvore<Cidade>();
                    arvoreCidades.LerArquivoDeRegistros(dlgAbrir.FileName);
                    arvoreCidades.PosicionarNoPrimeiro();

                    pbMapa.Invalidate();

                    situacaoAtual = Situacao.navegando;
                    

                    if (dlgAbrir.ShowDialog() == DialogResult.OK)
                    {
                        var origem = new FileStream(dlgAbrir.FileName, FileMode.OpenOrCreate);
                        var arquivo = new BinaryReader(origem);
                        Ligacao novaLigacao = new Ligacao();
                        int posicaoFinal = (int)arquivo.BaseStream.Length / novaLigacao.TamanhoRegistro - 1;
                        arquivo.BaseStream.Seek(0, SeekOrigin.Begin);
                        for(int i = 0; i < posicaoFinal; i++)
                        {
                            novaLigacao = new Ligacao();
                            novaLigacao.LerRegistro(arquivo, i);
                            var cidadeProcurada = new Cidade(novaLigacao.IdCidadeOrigem, 0, 0);
                            if(arvoreCidades.Existe(cidadeProcurada))
                                arvoreCidades.Atual.Info.Saidas.InserirEmOrdem(novaLigacao);
                        }
                        arvoreCidades.PosicionarNoPrimeiro();
                    }

                    AtualizarTela();
                }
                catch (Exception)
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
            if (arvoreCidades != null)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Coral, 3);
                Brush brush = new SolidBrush(Color.LightGray);
                Brush brush2 = new SolidBrush(Color.Black);
                Font fonte = new Font("Arial", 10);

                //EXIBIR LIGAÇOES NO MAPA
                /*
                listaLigacoes.PosicionarNoPrimeiro();
                while (listaLigacoes.DadoAtual() != null)
                {
                    var ligacaoAtual = listaLigacoes.DadoAtual();
                    var cidadeOrigem = cidades[indiceDaCidade(ligacaoAtual.IdCidadeOrigem)];
                    var cidadeDestino = cidades[indiceDaCidade(ligacaoAtual.IdCidadeDestino)];
                    g.DrawLine(pen, (float)cidadeOrigem.X * pbMapa.Width, (float)cidadeOrigem.Y * pbMapa.Height, (float)cidadeDestino.X * pbMapa.Width, (float)cidadeDestino.Y * pbMapa.Height);
                    listaLigacoes.AvancarPosicao();
                }

                if (exibindoCaminho)
                {
                    pen.Color = Color.Aquamarine;
                    var pilhaOriginal = caminhos[indiceCaminhoExibido].Clone();
                    while (!caminhos[indiceCaminhoExibido].EstaVazia())
                    {
                        var ligacao = caminhos[indiceCaminhoExibido].Desempilhar();
                        var origem = cidades[indiceDaCidade(ligacao.IdCidadeOrigem)];
                        var destino = cidades[indiceDaCidade(ligacao.IdCidadeDestino)];
                        g.DrawLine(pen, (float)origem.X * pbMapa.Width, (float)origem.Y * pbMapa.Height, (float)destino.X * pbMapa.Width, (float)destino.Y * pbMapa.Height);
                    }
                    caminhos[indiceCaminhoExibido] = pilhaOriginal;
                    exibindoCaminho = false;
                }*/
                /////////////////////////////////////////

                pen.Color = Color.Black;
                pen.Width = 2;

                PercorrerInOrdem(arvoreCidades.Raiz, (NoArvore<Cidade> r) =>
                {
                    Cidade cidade = r.Info;

                    //DESENHAR CIDADES
                    if (cidade == arvoreCidades.Atual.Info)
                    {
                        Pen penAtual = new Pen(Color.Black, 2);
                        Brush brushAtual = new SolidBrush(Color.Yellow);
                        g.DrawEllipse(penAtual, (float)cidade.X * pbMapa.Width - 5, (float)cidade.Y * pbMapa.Height - 5, 10, 10);
                        g.FillEllipse(brushAtual, (float)cidade.X * pbMapa.Width - 4, (float)cidade.Y * pbMapa.Height - 4, 8, 8);
                        g.DrawString(cidade.Nome, fonte, brush2, (float)cidade.X * pbMapa.Width - 8, (float)cidade.Y * pbMapa.Height + 6);
                    }
                    else
                    {
                        g.DrawEllipse(pen, (float)cidade.X * pbMapa.Width - 5, (float)cidade.Y * pbMapa.Height - 5, 10, 10);
                        g.FillEllipse(brush, (float)cidade.X * pbMapa.Width - 4, (float)cidade.Y * pbMapa.Height - 4, 8, 8);
                        g.DrawString(cidade.Nome, fonte, brush2, (float)cidade.X * pbMapa.Width - 8, (float)cidade.Y * pbMapa.Height + 6);
                    }
                });
            }
        }

        void PercorrerInOrdem(NoArvore<Cidade> r,  Action<NoArvore<Cidade>> operacao)
        {
            if (r != null)
            {
                PercorrerInOrdem(r.Esq, operacao);
                operacao(r);
                PercorrerInOrdem(r.Dir, operacao);
            }
        }

        // atualiza a tela de acordo com a situação em que o usuário está definindo como os botões
        // ficarão (por meio do método TestarBotoes, a mensagem que aparecerá no statusStrip para
        // auxiliar o usuário e os campos que precisarão ser limpos para que o usuário digite
        void AtualizarTela()
        {
            switch (situacaoAtual)
            {
                case Situacao.navegando:
                    {
                        Cidade cidadeAtual = arvoreCidades.Atual.Info;
                        TestarBotoes();

                        if (cidadeAtual != null)
                        {
                            txtNome.Text = cidadeAtual.Nome;
                            nudX.Value = (decimal)cidadeAtual.X;
                            nudY.Value = (decimal)cidadeAtual.Y;

                            //Colocar informaçoes no DGV
                            dgvCaminhos.Columns.Clear();
                            dgvCaminhos.Rows.Clear();
                            dgvCaminhos.Columns.Add("cabecalho", "");
                            dgvCaminhos.Rows.Add(2);
                            dgvCaminhos[0, 0].Value = "Destino  :";
                            dgvCaminhos[0, 1].Value = "Distancia:";
                            dgvCaminhos[0, 2].Value = "Tempo    :";

                            var saidasAtual = cidadeAtual.Saidas;
                            saidasAtual.IniciarPercursoSequencial();
                            int n = 1;
                            while (saidasAtual.PodePercorrer())
                            {
                                dgvCaminhos.Columns.Add($"{n}", "");
                                dgvCaminhos[n, 0].Value = saidasAtual.Atual.Info.IdCidadeDestino;
                                dgvCaminhos[n, 1].Value = saidasAtual.Atual.Info.Distancia + " Km";
                                dgvCaminhos[n, 2].Value = saidasAtual.Atual.Info.Tempo + " min";
                                n++;
                            }
                        }
                        pbMapa.Invalidate();
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

                        txtOrigem.Text = "";
                        txtDestino.Text = "";
                        nudDistancia.Value = 0;
                        nudTempo.Value = 0;

                        if(tcCaminhosCidades.SelectedTab == tpCidades)
                            txtNome.Focus();
                        else
                            txtOrigem.Focus();

                        stRegistro.Items[0].Text = "Mensagem: Informe o nome da cidade, clique na posição do mapa onde deseja incluir e depois clique em salvar";
                    }
                    break;

                case Situacao.editando: 
                    {
                        TestarBotoes();

                        txtNome.Focus();
                    }
                    break;
            }
        }

        // indica quais botões poderão ser habilitados de acordo
        // coma situação em que o usuário se encontra no programa
        void TestarBotoes()
        {
            switch (situacaoAtual)
            {
                case Situacao.navegando:
                    {
                        btnProcurar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnSalvar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnEditar.Enabled = true;
                        tpCaminhos.Enabled = true;
                        tpCidades.Enabled = true;
                    }
                    break;

                case Situacao.pesquisando:
                    {
                        btnNovo.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnEditar.Enabled = false;
                    }
                    break;

                case Situacao.incluindo:
                    {
                        btnProcurar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnEditar.Enabled = false;
                        if (tcCaminhosCidades.SelectedTab == tpCaminhos)
                            tpCidades.Enabled = false;
                        else
                            tpCaminhos.Enabled = false;
                    }
                    break;

                case Situacao.editando:
                    {
                        btnProcurar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnNovo.Enabled = false;
                    }
                    break;
            }
        }

        // a partir daqui, o que será apresentado no código é o que cada
        // botão faz ao ser clicado pelo usuário, cada um realizando as suas
        // respectivas funções

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            situacaoAtual = Situacao.pesquisando;
            AtualizarTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (situacaoAtual)
            {
                case Situacao.navegando:
                    {
                        //Chama o método que executa a operação de salvar em arquivo .txt
                        Salvar();
                    }
                    break;

                case Situacao.pesquisando:
                    {
                        // se a situação for pesquisando, será preciso ver se aquela cidade existe
                        // para que quando o usuário clique no botão de salvar, as respectivas informações
                        // daquela cidade apareçam nos devidos campos
                        if (arvoreCidades.Existe(new Cidade(txtNome.Text, 0, 0)))
                        {
                            situacaoAtual = Situacao.navegando;
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
                        try
                        {
                            if (tcCaminhosCidades.SelectedTab == tpCidades)
                            {
                                if (txtNome.Text != "")
                                {
                                    arvoreCidades.IncluirNovoRegistro(new Cidade(txtNome.Text, (double)Math.Round(nudX.Value, 3), (double)Math.Round(nudY.Value, 3)));
                                    situacaoAtual = Situacao.navegando;
                                    AtualizarTela();
                                    pbMapa.Invalidate();
                                }
                                else
                                    MessageBox.Show("O nome da cidade não pode ser vazio");
                            }
                            else
                            {
                                if (txtOrigem.Text != "" && txtDestino.Text != "")
                                {
                                    arvoreCidades.Atual.Info.Saidas.InserirEmOrdem(new Ligacao(txtOrigem.Text, txtDestino.Text, (int)Math.Round(nudDistancia.Value), (int)Math.Round(nudTempo.Value)));
                                    situacaoAtual = Situacao.navegando;
                                    AtualizarTela();
                                }
                                else
                                    MessageBox.Show("Os nomes fornecidos são inválidos");
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("A cidade que deseja incluir já está registrada!");
                        }
                    }
                    break;

                case Situacao.editando:
                    {
                        try
                        {
                            var cidade = arvoreCidades.Atual.Info;
                            cidade.Nome = txtNome.Text;
                            cidade.X = (double)Math.Round(nudX.Value, 3);
                            cidade.Y = (double)Math.Round(nudY.Value, 3);
                            situacaoAtual = Situacao.navegando;
                            AtualizarTela();
                            pbMapa.Invalidate();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("A cidade que deseja incluir já está registrada!");
                        }
                    }
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            situacaoAtual = Situacao.navegando;
            AtualizarTela();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            situacaoAtual = Situacao.incluindo;
            AtualizarTela();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            situacaoAtual = Situacao.editando;
            AtualizarTela();
        }

        private void pbMapa_MouseClick(object sender, MouseEventArgs e)
        {
            if (situacaoAtual == Situacao.incluindo || situacaoAtual == Situacao.editando)
            {
                //depois ver como mudar cursor para incluir cidades
                nudX.Value = (decimal)e.X / pbMapa.Width;
                nudY.Value = (decimal)e.Y / pbMapa.Height;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja excluir esse registro permanentemente?",
                                "Deseja Excluir?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                situacaoAtual = Situacao.excluindo;
                arvoreCidades.ApagarNo(arvoreCidades.Atual.Info);
                situacaoAtual = Situacao.navegando; //olhar depois onde que o atual fica
                AtualizarTela();
                pbMapa.Invalidate();
            }
        }

        // não permitir que o usuário saia do programa sem salvar as alterações que
        // o mesmo fez em seu arquivo durante a utilização do programa
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja realmente encerrar a execução do programa?",
                                "Deseja sair?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você deseja salvar antes de sair?",
                                "Deseja salvar?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Salvar();
            }
        }

        void Salvar()
        {
            // mostrará a tela para que o usuário salve o arquivo
            if (dlgSalvar.ShowDialog() == DialogResult.OK)
            {
                //gravará os dados armazenados na lista dupla no arquivo fornecido pelo usuário 
                arvoreCidades.GravarArquivoDeRegistros(dlgSalvar.FileName);
            }
        }

        //Backtracking de cidades
        /*
        private void btnAcharCaminho_Click(object sender, EventArgs e)
        {
            var cidadeOrigem = cidades[cbOrigem.SelectedIndex];
            var cidadeDestino = cidades[cbDestino.SelectedIndex];
            caminhos = BuscarTodosOsCaminhosEntre(cidadeOrigem, cidadeDestino);
            if (caminhos != null)
            {
                dgvCaminhos.Columns.Clear();
                int i = 1;
                foreach (var caminho in caminhos)
                {
                    int distanciaTotal = 0;
                    var aux = new PilhaVetor<Ligacao>(1000);
                    while (!caminho.EstaVazia())
                    {
                        var dado = caminho.Desempilhar();
                        distanciaTotal += dado.Distancia;
                        aux.Empilhar(dado);
                    }
                    while (!aux.EstaVazia())
                    {
                        caminho.Empilhar(aux.Desempilhar());
                    }
                    dgvCaminhos.Columns.Add(distanciaTotal.ToString(), distanciaTotal.ToString());
                }

                var melhorCaminho = MelhorCaminho(caminhos);
                dgvMelhorCaminho.Rows.Clear();
                while (!melhorCaminho.EstaVazia())
                {
                    var dado = melhorCaminho.Desempilhar();
                    dgvMelhorCaminho.Rows.Add(dado.IdCidadeOrigem);
                    if (melhorCaminho.EstaVazia())
                        dgvMelhorCaminho.Rows.Add(dado.IdCidadeDestino);
                }
            }
            else
            {
                MessageBox.Show("Não há caminhos disponiveis");
            }
        }

        PilhaVetor<Ligacao> BuscarCaminho(Cidade origem, Cidade destino)
        {
            Cidade cidadeAtual, saidaAtual;
            bool achouCaminho = false,
            naoTemSaida = false;
            int qtasCidades = cidades.Length;
            bool[] passou = new bool[qtasCidades];
            // inicia os valores de “passou” pois ainda não foi em nenhuma cidade
            for (int indice = 0; indice < qtasCidades; indice++)
                passou[indice] = false;
            //lsb.Items.Clear();
            cidadeAtual = origem;
            saidaAtual = cidades[0];
            var pilha = new PilhaVetor<Ligacao>(1000);
            while (!achouCaminho && !naoTemSaida)
            {
                int iSaidaAtual = indiceDaCidade(saidaAtual.Nome);
                naoTemSaida = (cidadeAtual == origem && saidaAtual == cidades[qtasCidades - 1] && pilha.EstaVazia());
                if (!naoTemSaida)
                {
                    do
                    {
                        // se não há saída pela cidade testada, verifica a próxima
                        int iCidadeAtual = indiceDaCidade(cidadeAtual.Nome);

                        if (matrizDeAdjacencia[iCidadeAtual, iSaidaAtual].Distancia == 0)
                            saidaAtual = cidades[++iSaidaAtual];
                        else
                             // se já passou pela cidade testada, vê se a próxima cidade permite saída 
                             if (passou[iSaidaAtual])
                            saidaAtual = cidades[++iSaidaAtual];
                        else
                                // se chegou na cidade desejada, empilha o local
                                // e termina o processo de procura de caminho
                                if (saidaAtual == destino)
                        {
                            var ligacao = matrizDeAdjacencia[iCidadeAtual, iSaidaAtual];
                            Ligacao movim = new Ligacao(cidadeAtual.Nome, saidaAtual.Nome, ligacao.Distancia, 0, ligacao.Custo);
                            pilha.Empilhar(movim);
                            achouCaminho = true;
                            //lsb.Items.Add($"Saiu de {cidadeAtual} para {saidaAtual}");
                        }
                        else
                        {
                            //lsb.Items.Add($"Saiu de {cidadeAtual} para {saidaAtual}");
                            var ligacao = matrizDeAdjacencia[iCidadeAtual, iSaidaAtual];
                            Ligacao movim = new Ligacao(cidadeAtual.Nome, saidaAtual.Nome, ligacao.Distancia, 0, ligacao.Custo);
                            pilha.Empilhar(movim);
                            passou[iCidadeAtual] = true;
                            cidadeAtual = saidaAtual; // muda para a nova cidade 
                            saidaAtual = cidades[0]; // reinicia busca de saídas da nova
                            iSaidaAtual = 0;                  // cidade a partir da primeira cidade
                        }
                    }
                    while ((saidaAtual != cidades[qtasCidades - 1]) && !achouCaminho);
                } /// if ! naoTemSaida
                if (!achouCaminho)
                    if (!pilha.EstaVazia())
                    {
                        var movim = pilha.Desempilhar();
                        saidaAtual = cidades[indiceDaCidade(movim.IdCidadeDestino)];
                        cidadeAtual = cidades[indiceDaCidade(movim.IdCidadeOrigem)];
                        //lsb.Items.Add($"Voltando de {saidaAtual} para {cidadeAtual}");
                        saidaAtual = cidades[indiceDaCidade(saidaAtual.Nome) + 1];
                    }
            }
            var saida = new PilhaVetor<Ligacao>(1000);
            if (achouCaminho)
            { // desempilha a configuração atual da pilha
              // para a pilha da lista de parâmetros
                while (!pilha.EstaVazia())
                {
                    Ligacao movim = pilha.Desempilhar();
                    saida.Empilhar(movim);
                }
            }
            return saida;
        }

        PilhaVetor<Ligacao> MelhorCaminho(List<PilhaVetor<Ligacao>> caminhos)
        {
            int menor = int.MaxValue;
            PilhaVetor<Ligacao> menorCaminho = new PilhaVetor<Ligacao>(1000);
            for (int i = 0; i < dgvCaminhos.Columns.Count; i++) //encontra o melhor caminho usando o criterio de distancia
            {
                if (int.Parse(dgvCaminhos.Columns[i].HeaderText) < menor)
                {
                    menorCaminho = caminhos[i].Clone();
                    menor = int.Parse(dgvCaminhos.Columns[i].HeaderText);
                }
            }
            //verificar se é nulo
            var saida = new PilhaVetor<Ligacao>(1000);
            while (!menorCaminho.EstaVazia())
            {
                saida.Empilhar(menorCaminho.Desempilhar());
            }

            lbMelhorCaminho.Text = $"Melhor caminho {menor}km";
            return saida;
        }

        List<PilhaVetor<Ligacao>> BuscarTodosOsCaminhosEntre(Cidade origem, Cidade destino)
        {
            List<PilhaVetor<Ligacao>> caminhos = new List<PilhaVetor<Ligacao>>();

            Cidade cidadeAtual, saidaAtual;
            bool achouCaminho = false,
            naoTemSaida = false;
            int qtasCidades = cidades.Length;
            bool[] passou = new bool[qtasCidades];
            // inicia os valores de “passou” pois ainda não foi em nenhuma cidade
            for (int indice = 0; indice < qtasCidades; indice++)
                passou[indice] = false;
            cidadeAtual = origem;
            saidaAtual = cidades[0];
            var pilha = new PilhaVetor<Ligacao>(1000);
            while (!naoTemSaida)
            {

                while (!achouCaminho && !naoTemSaida)
                {
                    int iSaidaAtual = indiceDaCidade(saidaAtual.Nome);
                    naoTemSaida = (cidadeAtual == origem && saidaAtual == cidades[qtasCidades - 1] && pilha.EstaVazia());
                    if (!naoTemSaida)
                    {
                        while (iSaidaAtual < qtasCidades && !achouCaminho)
                        {
                            // se não há saída pela cidade testada, verifica a próxima
                            int iCidadeAtual = indiceDaCidade(cidadeAtual.Nome);

                            if (matrizDeAdjacencia[iCidadeAtual, iSaidaAtual].Distancia == 0)
                            {
                                iSaidaAtual++;
                                if (iSaidaAtual < qtasCidades)
                                    saidaAtual = cidades[iSaidaAtual];
                            }
                            else
                                 // se já passou pela cidade testada, vê se a próxima cidade permite saída 
                                 if (passou[iSaidaAtual])
                            {
                                iSaidaAtual++;
                                if (iSaidaAtual < qtasCidades)
                                    saidaAtual = cidades[iSaidaAtual];
                            }
                            else
                                    // se chegou na cidade desejada, empilha o local
                                    // e termina o processo de procura de caminho
                                    if (saidaAtual == destino)
                            {
                                var ligacao = matrizDeAdjacencia[iCidadeAtual, iSaidaAtual];
                                Ligacao movim = new Ligacao(cidadeAtual.Nome, saidaAtual.Nome, ligacao.Distancia, 0, ligacao.Custo);
                                pilha.Empilhar(movim);
                                achouCaminho = true;
                            }
                            else
                            {
                                var ligacao = matrizDeAdjacencia[iCidadeAtual, iSaidaAtual];
                                Ligacao movim = new Ligacao(cidadeAtual.Nome, saidaAtual.Nome, ligacao.Distancia, 0, ligacao.Custo);
                                pilha.Empilhar(movim);
                                passou[iCidadeAtual] = true;
                                cidadeAtual = saidaAtual; // muda para a nova cidade 
                                saidaAtual = cidades[0]; // reinicia busca de saídas da nova
                                iSaidaAtual = 0;                  // cidade a partir da primeira cidade
                            }
                        }
                    } /// if ! naoTemSaida
                    if (!achouCaminho)
                        if (!pilha.EstaVazia())
                        {
                            do
                            {
                                var movim = pilha.Desempilhar();
                                saidaAtual = cidades[indiceDaCidade(movim.IdCidadeDestino)];
                                cidadeAtual = cidades[indiceDaCidade(movim.IdCidadeOrigem)];
                                passou[indiceDaCidade(saidaAtual.Nome)] = false;
                            }
                            while (saidaAtual == cidades[qtasCidades - 1] && !pilha.EstaVazia());
                            saidaAtual = cidades[indiceDaCidade(saidaAtual.Nome) + 1]; //testa próxima saida
                        }
                }
                if (!naoTemSaida)
                {
                    caminhos.Add(pilha); //adiciona na lista de caminhos encontrados o caminho encontrado
                    pilha = pilha.Clone(); //clona o caminho encontrado
                    do
                    {
                        var ultimaLigacao = pilha.Desempilhar(); //desfaz o ultimo movimento
                        passou[indiceDaCidade(ultimaLigacao.IdCidadeDestino)] = false;
                        saidaAtual = cidades[indiceDaCidade(ultimaLigacao.IdCidadeDestino)];
                        cidadeAtual = cidades[indiceDaCidade(ultimaLigacao.IdCidadeOrigem)];
                    }
                    while (saidaAtual == cidades[qtasCidades - 1] && !pilha.EstaVazia());

                    for (int i = 0; i < passou.Length; i++) //reinicializa o vetor "passou"
                        passou[i] = false;

                    var copia = pilha.Clone();
                    while (!copia.EstaVazia())
                    {
                        passou[indiceDaCidade(copia.Desempilhar().IdCidadeOrigem)] = true;
                    }

                    saidaAtual = cidades[indiceDaCidade(saidaAtual.Nome) + 1]; //tenta encontrar um caminho a partir da próxima saida
                    achouCaminho = false;
                }
            }

            return caminhos;
        }*/

        //tratamento de evento para exibição de caminho selecionado
        private void dgvCaminhos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (caminhos != null)
            {
                exibindoCaminho = true;
                indiceCaminhoExibido = e.ColumnIndex;
                lbKm.Text = $"Km do caminho selecionado: ({dgvCaminhos.Columns[e.ColumnIndex].HeaderText} km)";
                pbMapa.Invalidate();
            }*/
        }

        private void dgvCaminhos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}