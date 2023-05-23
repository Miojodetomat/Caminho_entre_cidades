using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ListaDupla<Dado> where Dado : IComparable<Dado>, IRegistro
{
    NoListaDupla<Dado> primeiro, ultimo, atual;
    int quantosNos;

    public ListaDupla()
    {
        primeiro = ultimo = atual = null;
        quantosNos = 0;
    }

    public bool EstaVazia
    {
        get => primeiro == null;
    }

    public void InserirAntesDoInicio(Dado novoDado)
    {
        var novoNo = new NoListaDupla<Dado>(novoDado);

        if (EstaVazia)
            ultimo = novoNo;

        primeiro.Anterior = novoNo;
        novoNo.Proximo = primeiro;
        primeiro = novoNo;
        quantosNos++;
    }

    public void InserirAposFim(Dado novoDado)
    {
        var novoNo = new NoListaDupla<Dado>(novoDado);

        if (EstaVazia)
            primeiro = novoNo;

        ultimo.Proximo = novoNo;
        novoNo.Anterior = ultimo;
        ultimo = novoNo;
        quantosNos++;
    }

    public bool ExisteDado(Dado dadoProcurado)
    {
        if (EstaVazia)
            return false;

        atual = primeiro;
        while(atual != null)
        {
            if (atual.Info.CompareTo(dadoProcurado) == 0)
                return true;
            else
                if (atual.Info.CompareTo(dadoProcurado) < 0)
                    atual = atual.Proximo;
                else
                    if (atual.Info.CompareTo(dadoProcurado) > 0)
                        return false;
        }

        return false;
    }

    public void AvancarAtual() 
    { 
       atual = atual.Proximo;
    }

    public void RetrocederAtual() 
    { 
        atual = atual.Anterior;
    }

    public bool EstaNoPrimeiro
    {
        get => atual == primeiro;
    }

    public bool EstaNoUltimo
    {
        get => atual == ultimo;
    }

    public void ExcluirAtual()
    {
        if (!EstaVazia)
        {
            if (EstaNoPrimeiro)
                primeiro = atual.Proximo;
            if (EstaNoUltimo)
                ultimo = atual.Anterior;
            atual.Anterior.Proximo = atual.Proximo;
            atual.Proximo.Anterior = atual.Anterior;
            atual = atual.Proximo;
            quantosNos--;
        }
    }

    public void Excluir(Dado dadoAExcluir)
    {
        if(ExisteDado(dadoAExcluir))
        {
            ExcluirAtual();
        }
    }

    public void IncluirEmOrdem(Dado novoDado)
    {
        if (EstaVazia)
            InserirAntesDoInicio(novoDado);
        else
        {
            if (novoDado.CompareTo(primeiro.Info) < 0)
                InserirAntesDoInicio(novoDado);
            else
                if (novoDado.CompareTo(ultimo.Info) > 0)
                    InserirAposFim(novoDado);
                else
                    if(!ExisteDado(novoDado))
                    {
                        var novoNo = new NoListaDupla<Dado>(novoDado);
                        atual.Anterior.Proximo = novoNo;
                        novoNo.Anterior = atual.Anterior;
                        atual.Anterior = novoNo;
                        novoNo.Proximo = atual;
                        atual = novoNo;
                        quantosNos++;
                    }
                    else
                        throw new Exception("Dado Já Existente");
        }
    }

    public void Ordenar()
    {
        var listaOrdenada = new ListaDupla<Dado>();
        while(!this.EstaVazia)
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
                listaOrdenada.InserirAposFim(oMenor.Info);
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

