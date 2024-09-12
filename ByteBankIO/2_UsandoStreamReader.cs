using ByteBankIO;

partial class Program
{
    static void UsandoStreamReader()
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
                var linha = leitor.ReadLine();
                ContaCorrente contaCorrente = ConverterStringParaContoCorrente(linha);

                string msg = $"{contaCorrente.Titular.Nome}: Conta número {contaCorrente.Numero}, ag {contaCorrente.Agencia}, Saldo {contaCorrente.Saldo}";
                Console.WriteLine(msg);
            }
        }

        Console.ReadLine();
    }

    static ContaCorrente ConverterStringParaContoCorrente(string linha)
    {
        string[] campos = linha.Split(',');

        int agencia = Convert.ToInt32(campos[0]);
        int numero = Convert.ToInt32(campos[1]);
        double saldo = Convert.ToDouble(campos[2].Replace('.', ','));
        string nomeTitular = campos[3];

        Cliente titular = new Cliente();
        titular.Nome = nomeTitular;

        ContaCorrente resultado = new ContaCorrente(agencia, numero);
        resultado.Depositar(saldo);
        resultado.Titular = titular;

        return resultado;
    }
}