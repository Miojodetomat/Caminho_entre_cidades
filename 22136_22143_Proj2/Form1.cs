using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

        ListaDupla<Ligacao> listaLigacoes;
        ListaDupla<Cidade> listaCidades;
        Cidade[] cidades;
        Ligacao[,] matrizDeAdjacencia;
        List<PilhaVetor<Ligacao>> caminhos;
        bool exibindoCaminho = false;
        int indiceCaminhoExibido = -1;

        // quando o formulário for carregado, será feita a leitura
        // dos arquivos necessários para o programa funcionar
        private void Form1_Load(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    listaCidades = new ListaDupla<Cidade>();
                    listaCidades.LerDados(dlgAbrir.FileName);

                    cidades = new Cidade[listaCidades.Tamanho];
                    for (int i = 0; i < listaCidades.Tamanho; i++)
                    {
                        cidades[i] = listaCidades[i];
                        cbOrigem.Items.Add(cidades[i].Nome);
                        cbDestino.Items.Add(cidades[i].Nome);
                    }
                    cbOrigem.SelectedIndex = 0;
                    cbDestino.SelectedIndex = 0;

                    matrizDeAdjacencia = new Ligacao[cidades.Length, cidades.Length];

                    pbMapa.Invalidate();

                    listaCidades.SituacaoAtual = Situacao.navegando;
                    listaCidades.PosicionarNoPrimeiro();
                    AtualizarTela();
                    lsbArquivo.Items.Add("Nome".PadRight(15, ' ') + " " + "X".PadLeft(6, ' ') + "Y".PadLeft(6, ' '));
                    listaCidades.ExibirDados(lsbArquivo);

                    if (dlgAbrir.ShowDialog() == DialogResult.OK)
                    {
                        listaLigacoes = new ListaDupla<Ligacao>();
                        listaLigacoes.LerDados(dlgAbrir.FileName);

                        for (int i = 0; i < cidades.Length; i++)
                        {
                            for (int j = 0; j < cidades.Length; j++)
                            {
                                matrizDeAdjacencia[i, j] = new Ligacao();
                            }
                        }

                        listaLigacoes.PosicionarNoPrimeiro();
                        while (listaLigacoes.DadoAtual() != null)
                        {
                            int indiceOrigem = indiceDaCidade(listaLigacoes.DadoAtual().IdCidadeOrigem);
                            int indiceDestino = indiceDaCidade(listaLigacoes.DadoAtual().IdCidadeDestino);
                            matrizDeAdjacencia[indiceOrigem, indiceDestino] = listaLigacoes.DadoAtual();
                            matrizDeAdjacencia[indiceDestino, indiceOrigem] = listaLigacoes.DadoAtual();

                            listaLigacoes.AvancarPosicao();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro de leitura no arquivo.");
                }
            }
        }

        int indiceDaCidade(string cidade)
        {
            for (int i = 0; i < cidades.Length; i++)
            {
                if (cidades[i].Nome == cidade)
                    return i;
            }

            throw new Exception("Cidade não está no vetor");
        }

        // no picturebox, assim que o arquivo solicitado for aberto
        // serão desenhadas as cidades descritas no mesmo (sobrescrevendo
        // a imagem do mapa)
        private void pbMapa_Paint(object sender, PaintEventArgs e)
        {
            if (listaCidades != null)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Coral, 3);
                Brush brush = new SolidBrush(Color.LightGray);
                Brush brush2 = new SolidBrush(Color.Black);
                Font fonte = new Font("Arial", 10);

                //EXIBIR LIGAÇOES NO MAPA

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
                }
                /////////////////////////////////////////

                pen.Color = Color.Black;
                pen.Width = 2;
                int posicaoAtual = listaCidades.PosicaoAtual;
                listaCidades.PosicionarNoPrimeiro();

                while (listaCidades.DadoAtual() != null)
                {
                    Cidade cidade = listaCidades.DadoAtual();
                    if (listaCidades.PosicaoAtual == posicaoAtual)
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
                    listaCidades.AvancarPosicao();
                }
                listaCidades.PosicionarEm(posicaoAtual);
            }
        }

        // atualiza a tela de acordo com a situação em que o usuário está definindo como os botões
        // ficarão (por meio do método TestarBotoes, a mensagem que aparecerá no statusStrip para
        // auxiliar o usuário e os campos que precisarão ser limpos para que o usuário digite
        void AtualizarTela()
        {
            switch (listaCidades.SituacaoAtual)
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
                        btnInicio.Enabled = true;
                        btnProximo.Enabled = true;
                        btnUltimo.Enabled = true;
                        btnProcurar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnSalvar.Enabled = true;
                        btnExcluir.Enabled = true;

                        if (listaCidades.EstaNoInicio)
                        {
                            btnAnterior.Enabled = false;
                            btnInicio.Enabled = false;
                        }

                        if (listaCidades.EstaNoFim)
                        {
                            btnProximo.Enabled = false;
                            btnUltimo.Enabled = false;
                        }
                    }
                    break;

                case Situacao.pesquisando:
                    {
                        btnAnterior.Enabled = false;
                        btnInicio.Enabled = false;
                        btnProximo.Enabled = false;
                        btnUltimo.Enabled = false;
                        btnNovo.Enabled = false;
                        btnExcluir.Enabled = false;
                    }
                    break;

                case Situacao.incluindo:
                    {
                        btnAnterior.Enabled = false;
                        btnInicio.Enabled = false;
                        btnProximo.Enabled = false;
                        btnUltimo.Enabled = false;
                        btnProcurar.Enabled = false;
                        btnExcluir.Enabled = false;
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
            switch (listaCidades.SituacaoAtual)
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
                        if (listaCidades.Incluir(new Cidade(txtNome.Text, (double)Math.Round(nudX.Value, 3), (double)Math.Round(nudY.Value, 3))))
                        {
                            listaCidades.SituacaoAtual = Situacao.navegando;
                            AtualizarTela();
                            lsbArquivo.Items.Clear();
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
                listaCidades.SituacaoAtual = Situacao.excluindo;
                listaCidades.ExcluirAtual();
                listaCidades.SituacaoAtual = Situacao.navegando;
                AtualizarTela();
                pbMapa.Invalidate();
                lsbArquivo.Items.Clear();
                listaCidades.ExibirDados(lsbArquivo);
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
                listaCidades.GravarDados(dlgSalvar.FileName);
            }
        }

        private void btnAcharCaminho_Click(object sender, EventArgs e)
        {
            var cidadeOrigem = cidades[cbOrigem.SelectedIndex];
            var cidadeDestino = cidades[cbDestino.SelectedIndex];
            caminhos = BuscarTodosOsCaminhosEntre(cidadeOrigem, cidadeDestino);
            if (caminhos != null)
            {
                dgvCaminhos.Columns.Clear();
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
                    dgvMelhorCaminho.Rows.Add(melhorCaminho.Desempilhar().IdCidadeOrigem);
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
            for(int i = 0; i < dgvCaminhos.Columns.Count; i++)
            {
                if (int.Parse(dgvCaminhos.Columns[i].HeaderText) < menor)
                {
                    menorCaminho = caminhos[i].Clone();
                    menor = int.Parse(dgvCaminhos.Columns[i].HeaderText);
                }
            }
            //verificar se é nulo
            var saida = new PilhaVetor<Ligacao>(1000);
            while(!menorCaminho.EstaVazia())
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
            //lsb.Items.Clear();
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
                                    if(iSaidaAtual < qtasCidades)
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
                    } /// if ! naoTemSaida
                    if (!achouCaminho)
                        if (!pilha.EstaVazia())
                        {
                            do
                            {
                                var movim = pilha.Desempilhar();
                                saidaAtual = cidades[indiceDaCidade(movim.IdCidadeDestino)];
                                cidadeAtual = cidades[indiceDaCidade(movim.IdCidadeOrigem)];
                                //lsb.Items.Add($"Voltando de {saidaAtual} para {cidadeAtual}");
                            }
                            while (saidaAtual == cidades[qtasCidades - 1] && !pilha.EstaVazia());
                            saidaAtual = cidades[indiceDaCidade(saidaAtual.Nome) + 1];
                        }
                }
                if (!naoTemSaida)
                {
                    caminhos.Add(pilha);
                    pilha = pilha.Clone();
                    do
                    {
                        var ultimaLigacao = pilha.Desempilhar();
                        passou[indiceDaCidade(ultimaLigacao.IdCidadeDestino)] = false;
                        saidaAtual = cidades[indiceDaCidade(ultimaLigacao.IdCidadeDestino)];
                        cidadeAtual = cidades[indiceDaCidade(ultimaLigacao.IdCidadeOrigem)];
                        //lsb.Items.Add($"Voltando de {saidaAtual} para {cidadeAtual}");      
                    }
                    while (saidaAtual == cidades[qtasCidades - 1] && !pilha.EstaVazia());

                    saidaAtual = cidades[indiceDaCidade(saidaAtual.Nome) + 1];
                    achouCaminho = false;
                }
            }

            return caminhos;
        }

        private void dgvCaminhos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (caminhos != null)
            {
                exibindoCaminho = true;
                indiceCaminhoExibido = e.ColumnIndex;
                lbKm.Text = $"Km do caminho selecionado: ({dgvCaminhos.Columns[e.ColumnIndex].HeaderText} km)";
                pbMapa.Invalidate();
            }
        }

        private void dgvCaminhos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}