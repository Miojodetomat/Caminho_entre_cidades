using System.IO;

// Nome: Hugo Gomes Soares - RA: 22136
// Nome: Maria Eduarda de Jesus Padovan - RA: 22143
public interface IRegistro<Dado>
{
    Dado LerRegistro(StreamReader arquivo);
    string ParaArquivo();
    void GravarRegistro(StreamWriter arquivo);
}