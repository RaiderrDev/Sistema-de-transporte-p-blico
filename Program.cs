using System;
using System.Collections.Generic;
class CPTM
{
    static void Main()
    {
        //Instancie aqui para testar as funcionalidades, exemplo:
        BilheteUnico bilheteUnico = new BilheteUnico(200);
        Console.WriteLine(bilheteUnico.Identificacao);

        //criando uma pessoa com bilhete
        Pessoa pessoa = new Pessoa("Samuel", bilheteUnico);
        
        //testando métodos
        EstacaoCPTM.Recarga(pessoa, 500);
        EstacaoCPTM.ValidarBilhete(pessoa);
        pessoa.VerSaldo();

        //instanciando um onibus com rotas
        OnibusSP onibus = new OnibusSP();

        List<string> rotas = new List<string>{"Jabaquara", "Diadema", "ABC-Paulista", "Interlagos"};

        onibus.AdicionarParadas(rotas); //passaando as rotas via list

        //tentando pagar um onibus
        onibus.PagarOnibus(pessoa);
    }
}