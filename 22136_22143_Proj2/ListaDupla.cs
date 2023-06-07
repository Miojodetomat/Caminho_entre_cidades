using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Nome: Hugo Gomes Soares - RA: 22136
// Nome: Maria Eduarda de Jesus Padovan - RA: 22143

public class ListaDupla<Dado> : IDados<Dado> where Dado : IComparable<Dado>, IRegistro<Dado>, new()
{
    NoListaDupla<Dado> primeiro, ultimo, atual;
    Situacao situacaoAtual;
    int quantosNos;

    public ListaDupla()
    {
        primeiro = ultimo = atual = null;
        quantosNos = 0;
    }

    public bool EstaVazio
    {
        get => primeiro == null;
    }

    public bool IncluirNoInicio(Dado novoDado)
    {
        var novoNo = new NoListaDupla<Dado>(novoDado);

        if (EstaVazio)
        {
            ultimo = novoNo;
        }
        else
            if (primeiro.Info.CompareTo(novoDado) == 0)
                return false;
            else
            {
                novoNo.Proximo = primeiro;
                primeiro.Anterior = novoNo;
            }

        primeiro = novoNo;
        atual = primeiro;
        quantosNos++;

        return true;
    }

    public bool IncluirAposFim(Dado novoDado)
    {
        var novoNo = new NoListaDupla<Dado>(novoDado);

        if (EstaVazio)
        {
            primeiro = novoNo;
        }
        else
            if (ultimo.Info.CompareTo(novoDado) == 0)
                return false;
        else
        {
            ultimo.Proximo = novoNo;
            novoNo.Anterior = ultimo;
        }

        ultimo = novoNo;
        atual = ultimo;
        quantosNos++;

        return true;
    }

    public bool Existe(Dado dadoProcurado, out int ondeEsta)
    {
        ondeEsta = 0;
        if (EstaVazio)
            return false;

        atual = primeiro;
        while(atual != null)
        {
            if (atual.Info.CompareTo(dadoProcurado) == 0)
                return true;
            else
                if (atual.Info.CompareTo(dadoProcurado) < 0)
                { 
                    atual = atual.Proximo;
                    ondeEsta++;
                }
                else
                    if (atual.Info.CompareTo(dadoProcurado) > 0)
                        return false;
        }

        return false;
    }

    public void AvancarPosicao() 
    { 
       atual = atual.Proximo;
    }

    public void RetrocederPosicao() 
    { 
        atual = atual.Anterior;
    }

    public bool EstaNoInicio
    {
        get => atual == primeiro;
    }

    public bool EstaNoFim
    {
        get => atual == ultimo;
    }
    public Situacao SituacaoAtual { get => situacaoAtual ; set => situacaoAtual = value; }
    public int PosicaoAtual 
    { 
       get 
       {
            Existe(atual.Info, out int pAtual);
            return pAtual;
       }

       set => PosicionarEm(value); 
    }

    public int Tamanho => quantosNos;

    public Dado this[int indice] 
    { 
        get
        {
            PosicionarEm(indice);
            return DadoAtual();
        }

        set
        {
            PosicionarEm(indice);
            this.atual.Info = value;
        }
    }

    public bool ExcluirAtual()
    {
        if (!EstaVazio)
        {
            if (EstaNoInicio)
                primeiro = atual.Proximo;
            if (EstaNoFim)
                ultimo = atual.Anterior;
            atual.Anterior.Proximo = atual.Proximo;
            atual.Proximo.Anterior = atual.Anterior;
            atual = atual.Proximo;
            quantosNos--;
            return true;
        }
        return false;
    }

    public bool Excluir(Dado dadoAExcluir)
    {
        if(Existe(dadoAExcluir, out int posicao))
        {
            return ExcluirAtual();
        }

        return false;
    }

    public bool Incluir(Dado novoDado)
    {
        if (EstaVazio)
            return IncluirNoInicio(novoDado);
        else
        {
            if (novoDado.CompareTo(primeiro.Info) < 0)
                return IncluirNoInicio(novoDado);
            else
                if (novoDado.CompareTo(ultimo.Info) > 0)
                    return IncluirAposFim(novoDado);
                else
                    if(!Existe(novoDado, out int posicao))
                        return Incluir(novoDado, posicao);
                    else
                        return false;
        }
    }

    public bool Incluir(Dado novoDado, int posicaoDeInclusao)
    {
        if (posicaoDeInclusao <= 0)
            return IncluirNoInicio(novoDado);
        else
            if (posicaoDeInclusao >= Tamanho)
                return IncluirAposFim(novoDado);
        else
        {
            PosicionarEm(posicaoDeInclusao);
            if (atual.Info.CompareTo(novoDado) == 0)
                return false;

            var novoNo = new NoListaDupla<Dado>(novoDado);

            atual.Anterior.Proximo = novoNo;
            novoNo.Anterior = atual.Anterior;
            atual.Anterior = novoNo;
            novoNo.Proximo = atual;
            atual = novoNo;
            quantosNos++;

            return true;
        }
    }

    public void Ordenar()
    {
        var listaOrdenada = new ListaDupla<Dado>();
        while(!this.EstaVazio)
        {
            NoListaDupla<Dado> oMenor = this.primeiro;
            for(this.atual=this.primeiro;this.atual!=null;this.atual=this.atual.Proximo)
            {
                if (this.atual.Info.CompareTo(oMenor.Info) < 0)
                    oMenor = this.atual;
            }
            if(oMenor.Anterior == null)
            {
                this.primeiro = this.primeiro.Proximo;
            }
            if(oMenor.Proximo == null)
            {
                this.ultimo = this.ultimo.Anterior;
            }
            else
            {
                oMenor.Anterior.Proximo = oMenor.Proximo;
                this.quantosNos--;
                listaOrdenada.IncluirAposFim(oMenor.Info);
            }
        }

        this.primeiro = listaOrdenada.primeiro;
        this.ultimo = listaOrdenada.ultimo;
        this.atual = primeiro;
        this.quantosNos = listaOrdenada.quantosNos;
    }

    public void PosicionarNoPrimeiro()
    {
        atual = primeiro;
    }

    public void PosicionarNoUltimo()
    {
        atual = ultimo;
    }

    public void PosicionarEm(int posicaoDesejada)
    {
        if (posicaoDesejada < 0 || posicaoDesejada >= Tamanho)
            throw new Exception("Índice inválido!");
        if (posicaoDesejada == Tamanho - 1)
            PosicionarNoUltimo();
        else
        {
            PosicionarNoPrimeiro();
            for (int i = 0; i != posicaoDesejada; i++)
                AvancarPosicao();
        }
    }

    public Dado DadoAtual()
    {
        if (atual == null)
            return default;

        return atual.Info;
    }

    public void ExibirDados()
    {
        PosicionarNoPrimeiro();
        while (atual != null)
        {
            Console.WriteLine(atual.Info);
            AvancarPosicao();
        }
    }

    public void ExibirDados(ListBox lista)
    {
        int posicaoAtual = this.PosicaoAtual;
        PosicionarNoPrimeiro();
        while(atual != null)
        {
            lista.Items.Add(atual.Info);
            AvancarPosicao();
        }
        PosicionarEm(posicaoAtual);
    }

    public void ExibirDados(ComboBox lista)
    {
        PosicionarNoPrimeiro();
        while(atual != null)
        {
            lista.Items.Add(atual.Info);
            AvancarPosicao();
        }
    }

    public void ExibirDados(TextBox lista)
    {
        string texto = "";
        PosicionarNoPrimeiro();
        while(atual != null)
        {
            texto += $"{atual.Info}\n";
            AvancarPosicao();
        }
        lista.Text = texto;
    }

    public void LerDados(string nomeArquivo)
    {
        StreamReader arq = new StreamReader(nomeArquivo);
        while(!arq.EndOfStream)
        {
            Dado dado = new Dado();
            this.Incluir(dado.LerRegistro(arq));
        }
        arq.Close();
    }

    public void GravarDados(string nomeArquivo)
    {
        PosicionarNoPrimeiro();
        StreamWriter arq = new StreamWriter(nomeArquivo);
        while(atual != null)
        {
            atual.Info.GravarRegistro(arq);
            AvancarPosicao();
        }
        arq.Close();
    }
}

