class OnibusSP : Onibus
{
    public List<string> RotasSp { get; private set; }
    public static double TaxaFixa = 6.50; //variavel pra debitar do bilhete

    public OnibusSP()
    {
        RotasSp = new List<string>();
    }

    public override void ExibirRotas() //método sobrescrito pra exibir rotas
    {
        if (RotasSp.Count > 0)
        {
            Console.WriteLine("====Rotas Disponiveis====");
            foreach (var rota in RotasSp)
            {
                Console.WriteLine(rota);
            }
        }
        else
        {
            Console.WriteLine("Nenhuma rota disponivel.");
        }
    }

    public override void TempoEstimado() //Método que simula tempo estimado
    {
        if (RotasSp.Count > 0)
        {
            if (RotasSp.Count > 1 && RotasSp.Count < 5)
            {
                Console.WriteLine($"Tempo estimado: 20 minutos");
            }
            else if (RotasSp.Count > 5 && RotasSp.Count < 12)
            {
                Console.WriteLine("Tempo estimado: 60 minutos");
            }
            else
            {
                Console.WriteLine("Tempo estimado: 60+ minutos");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma rota pra estimar o tempo.");
        }
    }

    public override void PagarOnibus(Pessoa usuario) //método pra pagar a passagem e debitar do bilhete
    {
        if (usuario.Bilhete.Validado)
        {
            if (usuario.Bilhete.Saldo < TaxaFixa)
            {
                Console.WriteLine("Você não tem saldo suficiente pra pagar a passagem!");
                return;
            }
            Console.WriteLine($"Você pagou a passagem. Valor: {TaxaFixa}");
            usuario.Bilhete.Saldo -= TaxaFixa;
            return;
        }
        else
        {
            Console.WriteLine("Valide o bilhete antes de usar.");
            return;
        }
    }

    public void AdicionarParadas(List<string> listaRotas)  //Método pra adicionar rotas
    {
        if (listaRotas == null)
        {
            Console.WriteLine("Você não pode passar uma lista nula.");
            return;
        }
        Console.WriteLine("Rotas adicionadas com sucesso!");
        RotasSp.AddRange(listaRotas);
    }
}