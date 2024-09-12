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
}