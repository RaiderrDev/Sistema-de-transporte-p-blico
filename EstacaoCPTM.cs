class EstacaoCPTM
{
    public static double TaxaFixa = 5.00;
    public static void Recarga(Pessoa usuario, double saldo)
    {
        if (saldo > 200)
        {
            Console.WriteLine($"Você não pode realizar um depósito acima de 200,00R$");
            return;
        }
        if (saldo <= 0)
        {
            Console.WriteLine("Você não pode adicionar esse saldo");
        }
        else
        {
            saldo -= TaxaFixa;
            Console.WriteLine($"Saldo adicionado com sucesso! Taxa de serviço: {TaxaFixa:C2}R$");
            usuario.Bilhete.Saldo = saldo;
        }
    }

    public static void ValidarBilhete(Pessoa usuario)
    {
        if (usuario.Bilhete.Validado)
        {
            Console.WriteLine("O bilhete já foi validado.");
            return;
        }
        else 
        {
            Console.WriteLine("Bilhete validado com sucesso!");
            usuario.Bilhete.Validado = true;
        }
    }
}