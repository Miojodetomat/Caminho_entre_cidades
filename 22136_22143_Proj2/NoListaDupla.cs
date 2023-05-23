using System;

public class NoListaDupla<Dado> where Dado : IComparable<Dado>, IRegistro<Dado>
{
    NoListaDupla<Dado> anterior;
    Dado info;
    NoListaDupla<Dado> proximo;

    public NoListaDupla(Dado info)
    {
        this.info = info;
        anterior = proximo = null;
    }

    public Dado Info
    {
        get => info;
        set => info = value;
    }
    public NoListaDupla<Dado> Proximo { get => proximo; set => proximo = value; }
    public NoListaDupla<Dado> Anterior { get => anterior; set => anterior = value; }
}

