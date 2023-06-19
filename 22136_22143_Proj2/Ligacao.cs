using System;
using System.IO;

// Nome: Hugo Gomes Soares - RA: 22136
// Nome: Maria Eduarda de Jesus Padovan - RA: 22143
internal class Ligacao : IComparable<Ligacao>, IRegistro<Ligacao>
{
  const int tamCodigo = 15,
        tamDistancia = 4,
        tamCusto = 4;

    const int iniCodigoOrigem = 0,
              iniCodigoDestino = iniCodigoOrigem + tamCodigo,
              iniDistancia = iniCodigoDestino + tamCodigo,
              iniCusto = iniDistancia + tamDistancia;


  string idCidadeOrigem, idCidadeDestino;
  int distancia, tempo, custo;

  public Ligacao(string idCidadeOrigem, string idCidadeDestino, int distancia, int tempo, int custo)
  {
    this.idCidadeOrigem = idCidadeOrigem;
    this.idCidadeDestino = idCidadeDestino;
    this.distancia = distancia;
    this.tempo = tempo;
    this.custo = custo;
  }

    public Ligacao()
    {
        this.idCidadeDestino = "";
        this.idCidadeOrigem = "";
        this.tempo = 0;
        this.custo = 0;
        this.distancia = 0;
    }

  public string IdCidadeOrigem { get => idCidadeOrigem; set => idCidadeOrigem = value; }
  public string IdCidadeDestino { get => idCidadeDestino; set => idCidadeDestino = value; }
  public int Distancia { get => distancia; set => distancia = value; }
  public int Tempo { get => tempo; set => tempo = value; }
  public int Custo { get => custo; set => custo = value; }

  public int CompareTo(Ligacao outro)
  {
    return (idCidadeOrigem.ToUpperInvariant()+idCidadeDestino.ToUpperInvariant()).CompareTo(
            outro.idCidadeOrigem.ToUpperInvariant()+outro.idCidadeDestino.ToUpperInvariant());
  }

  public Ligacao LerRegistro(StreamReader arquivo)
  {
    if (arquivo != null) // arquivo aberto?
    {
      string linha = arquivo.ReadLine();
      IdCidadeOrigem = linha.Substring(iniCodigoOrigem, tamCodigo);
      IdCidadeDestino = linha.Substring(iniCodigoDestino, tamCodigo);
      Distancia = int.Parse(linha.Substring(iniDistancia, tamDistancia));
      Custo = int.Parse(linha.Substring(iniCusto, tamCusto));
      return this; // retorna o próprio objeto Contato, com os dados
    }
    return default(Ligacao);
  }
  public void GravarRegistro(StreamWriter arq)
  {
    if (arq != null)  // arquivo de saída aberto?
    {
      arq.WriteLine(ParaArquivo());
    }
  }
  public string ParaArquivo()
  {
    return $"{IdCidadeOrigem}{IdCidadeDestino}{Distancia:00000}{Tempo:0000}{Custo:00000}";
  }

  public override string ToString()
  {
    return $"{IdCidadeOrigem} {IdCidadeDestino} {Distancia:00000} {Tempo:0000} {Custo:00000}";
  }
}