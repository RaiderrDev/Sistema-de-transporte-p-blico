class BilheteUnico
{
    //propriedades publicas
    public double Saldo { get; set; }
    public string Identificacao { get; private set; } 
    public bool Validado { get; set; }

    public static Random Rand = new Random(); //Random pra gerar o identificador

    public BilheteUnico(double saldo) //construtor que define o saldo e gera o identificador
    {
        Saldo = saldo;
        Identificacao = "";

        while (Identificacao.Length < 8) //enquanto a quantidade de caracteres de identificação for menor que 8
        {
            string caracteres = "abcde8fghij1klmnopq2r3stuv58wxyz"; 
            int aleatorio = Rand.Next(0, caracteres.Length - 1); //escolhe aleatoriamente 

            Identificacao += caracteres[aleatorio]; //incrementa esses caracteres aleatorios no identificador, impedindo que identificações saiam igual
        }
    }
}