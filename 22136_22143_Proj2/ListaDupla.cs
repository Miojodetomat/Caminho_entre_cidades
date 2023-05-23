using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class ListaDupla<Dado> : IDados<Dado> where Dado : IComparable<Dado>, IRegistro<Dado>, new()
{
    NoListaDupla<Dado> primeiro, ultimo, atual;
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

    public bool IncluirNoInicio(Dado novoDado) //ver o porque q é bool
    {
        var novoNo = new NoListaDupla<Dado>(novoDado);
        
        if (EstaVazio)
            ultimo = novoNo;

        primeiro.Anterior = novoNo;
        novoNo.Proximo = primeiro;
        primeiro = novoNo;
        quantosNos++;

        return true;
    }

    public bool IncluirAposFim(Dado novoDado) //ver o porque que é bool
    {
        var novoNo = new NoListaDupla<Dado>(novoDado);

        if (EstaVazio)
            primeiro = novoNo;

        ultimo.Proximo = novoNo;
        novoNo.Anterior = ultimo;
        ultimo = novoNo;
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
    public Situacao SituacaoAtual { get => SituacaoAtual ; set => SituacaoAtual = value; }
    public int PosicaoAtual 
    { 
       get 
       {
            int pAtual = 0;
            Existe(atual.Info, out pAtual);
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
                    {
                        var novoNo = new NoListaDupla<Dado>(novoDado);
                        atual.Anterior.Proximo = novoNo;
                        novoNo.Anterior = atual.Anterior;
                        atual.Anterior = novoNo;
                        novoNo.Proximo = atual;
                        atual = novoNo;
                        quantosNos++;
                        return true;
                    }
                    else
                        return false;
        }
    }

    public bool Incluir(Dado novoDado, int posicaoDeInclusao)
    {
        PosicionarEm(posicaoDeInclusao);
        return Incluir(novoDado); //funciona, mas não é o ideal
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
        throw new NotImplementedException();
    }

    public Dado DadoAtual()
    {
        return atual.Info;
    }

    public void PercorrerLista()
    {
        int i = 0;
        for (atual = primeiro; atual != null; atual = atual.Proximo)
            i++;
       
        quantosNos = i;
    }

    public void PercorrerListaAoContrario()
    {
        int i = 0;
        for (atual = ultimo; atual != null; atual = atual.Anterior)
            i++;

        quantosNos = i;
    }

    public void ExibirDados()
    {
        throw new NotImplementedException();
    }

    public void ExibirDados(ListBox lista)
    {
        throw new NotImplementedException();
    }

    public void ExibirDados(ComboBox lista)
    {
        throw new NotImplementedException();
    }

    public void ExibirDados(TextBox lista)
    {
        throw new NotImplementedException();
    }

    public void LerDados(string nomeArquivo)
    {
        throw new NotImplementedException();
    }

    public void GravarDados(string nomeArquivo)
    {
        throw new NotImplementedException();
    }

    //criar métodos para:
    //
    //--Incluir nó antes do primeiro
    //--Incluir após o ultimo
    //Pesquisa sequencial ordenada que ajusta ponteiro atual
    //--Avançar nó atual
    //--Retroceder nó atual
    //--Função que informa se a lista está vazia ou não
    //--Função que informa se o ponteiro atual esta no primeiro ou não
    //--Função que informa se o ponterio atual está no último
    //--Remover o no atual (atualizar primeiro ou ultimo se necessario)
    //--Remover o nó que contem um dado como parametro
    //--incluir nó em ordem do campo chave dado
    //ordenar a lista duplamente ligada
    //--metodo que posiciona ponteiro atual no primeiro
    //--metodo que posiciona ponteiro atual no ultimo
    //--metodo que retorna info do nó apontado pelo ponterio atual
    //--Percorrer a lista do primeiro ao ultimo, usando o ponteiro atual
    //--Percorrer a lista do ultimo ao primeiro, usando o ponterio atual
}

