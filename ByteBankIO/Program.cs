using ByteBankIO;
using System.Globalization;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        // *** PARA TRABALHAR COM AS ARQUIVOS PEQUENOS ***        
        string[] linhas = File.ReadAllLines("contas.txt");
        Console.WriteLine(linhas.Length);

        //foreach (string linha in linhas)
        //{
        //    Console.WriteLine(linha);
        //}

        var bytesArquivo = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

        File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

        Console.WriteLine("Aplicação Finalizada!");

        Console.ReadLine();
    }
}