# Gerenciador de Transporte Público 

Este é um sistema em C# que simula o gerenciamento de um transporte público, com bilhetes únicos, recargas, validações e pagamento de passagens de ônibus, Fiz esse projeto para praticar **Programação Orientada a Objetos** e lógica em C#.

## O que esse projeto faz? 🛠️
Este é um sistema de console que simula algumas funcionalidades de um transporte público, como o sistema de bilhete único de São Paulo. Ele inclui:

- **Recarga de bilhete**: Adicione saldo ao seu bilhete (com uma taxa de serviço).
- **Validação de bilhete**: Valide seu bilhete antes de usar o transporte.
- **Pagamento de passagens**: Pague a passagem de ônibus, com débito automático do saldo.
- **Gerenciamento de rotas**: Adicione e exiba rotas de ônibus.
- **Estimativa de tempo**: Veja o tempo estimado da viagem com base nas rotas (estimativa simples).

É um projeto de iniciante, então tem muito espaço pra crescer, mas já mostra como usar herança, encapsulamento e composição em C#!

## Como usar? 🚀
1. **Pré-requisitos**:
   - Instale o .NET SDK (versão 8.0 ou superior).
   - Use VScode ou outra IDE.

2. **Passos para executar**:
   - Clone o repositório: `git clone <URL_DO_SEU_REPOSITORIO>`
   - Navegue até a pasta: `cd cptm`
   - Execute o projeto: `dotnet run`

3. **Exemplo de uso**:
   Trecho de código para testar algumas das funcionalidades, Você pode colocá-lo no Main da classe `CPTM`:

   ```csharp
   // Criar um bilhete com saldo inicial
   BilheteUnico bilhete = new BilheteUnico(50.0);
   Pessoa pessoa = new Pessoa("Samuel", bilhete);

   // Validar o bilhete
   EstacaoCPTM.ValidarBilhete(pessoa);

   // Ver o saldo
   pessoa.VerSaldo();

   // Criar um ônibus e adicionar rotas
   OnibusSP onibus = new OnibusSP();
   List<string> rotas = new List<string> { "Jabaquara", "Diadema", "Interlagos" };
   onibus.AdicionarParadas(rotas);

   // Exibir rotas e tempo estimado
   onibus.ExibirRotas();
   onibus.TempoEstimado();

   // Pagar a passagem
   onibus.PagarOnibus(pessoa);