int Idade;
double Renda;
bool TemRestricao,  Continuar =  true;

while (Continuar)
{
    Console.ResetColor();
    Console.Clear();
    //Entrada
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("===========================================");
    Console.WriteLine("Bem vindo ao Sistema de Analise de Credito!");
    Console.WriteLine("===========================================");
    Console.Write("Por gentileza inserir sua idade: ");
    while (!int.TryParse(Console.ReadLine(), out Idade))
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Erro! Digite um número válido para a idade!");
        Console.ForegroundColor= ConsoleColor.Green;
        Console.Write("Por favor, tente digitar sua IDADE novamente: ");
        
    }
    if (Idade < 21)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Recusado por IDADE");
        Console.WriteLine("\nPressione qualquer tecla para tentar novamente");
        Console.ReadKey();
        continue;
    }
    Console.Write("Por Gentileza Insira sua Renda Mensal em R$: ");
    while (!double.TryParse(Console.ReadLine(), out Renda))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Erro! Digite um número válido para a renda!");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Por favor, tente digitar sua RENDA novamente: ");
    }
    if(Renda < 2000)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Recusado por RENDA");
        Console.WriteLine("\nPressione qualquer tecla para tentar novamente");
        Console.ReadKey();
        continue;
    }
    Console.Write("Voce possui Restrição de credito? S/N: ");
    string Resposta = Console.ReadLine().ToUpper();
    while (Resposta != "S" && Resposta != "N")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Favor responder com S/N: ");
        Resposta = Console.ReadLine().ToUpper();
        Console.ForegroundColor = ConsoleColor.Green;
    }
    TemRestricao = (Resposta == "S");
    if (TemRestricao)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Recusado por RESTRIÇÃO DE CREDITO");
        Console.WriteLine("\nPressione qualquer tecla para tentar novamente");
        Console.ReadKey();
        continue;
    }
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n===========================================");
    Console.WriteLine("Parabéns! Seu crédito foi APROVADO!");
    Console.WriteLine("===========================================");

    Console.WriteLine("\nConsulta finalizada. Pressione qualquer tecla para reiniciar.");
    Console.ReadKey();
}