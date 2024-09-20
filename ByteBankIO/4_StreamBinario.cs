partial class Program
{
    static void EscritaBinaria()
    {
        using (FileStream fs = new FileStream("contaCorrente.txt", FileMode.Create))
        using (BinaryWriter escritor = new BinaryWriter(fs))
        {
            escritor.Write(456); // numero da agencia
            escritor.Write(546544); // numero da conta
            escritor.Write(4000.50); // saldo
            escritor.Write("Gustavo Braga");
        }
    }

    static void LeituraBinaria()
    {
        using (FileStream fs = new FileStream("contaCorrente.txt", FileMode.Open))
        using (BinaryReader leitor = new BinaryReader(fs))
        {
            int agencia = leitor.ReadInt32();
            int numeroConta = leitor.ReadInt32();
            double saldo = leitor.ReadDouble();
            string titular = leitor.ReadString();

            Console.WriteLine($"Agencia: {agencia}/{numeroConta} {titular} {saldo}");
        }
    }
}