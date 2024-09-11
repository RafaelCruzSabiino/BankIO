using System.Globalization;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        string enderecoDoArquivo = "contas.txt";

        using (FileStream fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            StreamReader leitor = new StreamReader(fluxoDeArquivo);

            //string? linha = leitor.ReadLine(); recupera a primeira linha do arquivo
            //string? texto = leitor.ReadToEnd(); recupera a arquivo todo
            //int numero = leitor.Read(); primeiro byte do arquivo

            while (!leitor.EndOfStream)
            {
                string? linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }
        }
           
        Console.ReadLine();
    }
}