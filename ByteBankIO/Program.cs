using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        string enderecoDoArquivo  = "contas.txt";
        FileStream fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
        byte[] buffer             = new byte[1024]; // 1KB

        fluxoDoArquivo.Read(buffer, 0, 1024);

        // public override int Read(byte[] array, int offset, int count);
    }
}