using ByteBankIO;
using System.Globalization;
using System.Text;

partial class Program
{
    static void CriandoArquivo()
    {
        string caminhoNovoArquivo = "contasExportadas.txt";

        using (FileStream fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            string contaComoString = "456, 7895, 4785.40, Gustavo Santos";

            Encoding encoding = Encoding.UTF8;

            byte[] bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CriarArquivoComWriter()
    {
        string caminhoNovoArquivo = "contasExportadas.txt";

        // FileMode.Create subscreve arquivo caso exista
        // FileMode.CreateNew caso haja algum arquivo criado com o mesmo nome, não consegue executar retornando erro.
        using (FileStream fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (StreamWriter escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("895, 4589, 498558.40, Rafael Sabino");
        }
    }
}