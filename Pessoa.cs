class Pessoa
{
    public string Nome { get; private set; } //Propriedade que só permite acessar o campo pelo construtor ou métodos da classe, mas só defini construtor
    public BilheteUnico Bilhete { get; private set; } //composição da classe BilheteUnico

    public Pessoa(string nome, BilheteUnico bilhete) //construtor
    {
        Nome = nome;
        Bilhete = bilhete;
    }

    public void RecarregarBilhete(Pessoa usuario, double saldo) //Método responsavel por chamar o método de recarga da classe EstacaoCPTM
    {
        EstacaoCPTM.Recarga(usuario, saldo);
    }

    public void VerSaldo() //Método pra ver saldo
    {
        if (Bilhete.Validado)
        {
            Console.WriteLine($"Nome no bilhete: {Nome}. Saldo: {Bilhete.Saldo}. IDentificador: {Bilhete.Identificacao}");
        }
        else
        {
            Console.WriteLine("Valide o saldo antes de usar o bilhete!");
        }
    }
}