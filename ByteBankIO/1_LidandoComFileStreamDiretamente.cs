﻿using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        string enderecoDoArquivo = "contas.txt";

        using (FileStream fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            int numeroDeBytesLidos = -1;
            byte[] buffer = new byte[1024]; // 1KB

            while (numeroDeBytesLidos != 0)
            {
                // public override int Read(byte[] array, int offset, int count);
                // Devoluções:
                // 0 número total de bytes lidos do buffer. Isso poderá ser menor que o número de
                // bytes solicitado se esse número de bytes não estiver disponível no momento, ou
                // zero, se o final do fluxo for atingido
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            //fluxoDoArquivo.Close();
        }

        Console.ReadLine();
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        UTF8Encoding uft8 = new UTF8Encoding();

        // public virtual string GetString(byte[] bytes, int index, int count);
        string texto = uft8.GetString(buffer, 0, bytesLidos);

        Console.WriteLine(texto);

        //foreach(byte meuByte in buffer)
        //{
        //    Console.Write(meuByte);
        //    Console.Write(" ");
        //}
    }
}