using System.ComponentModel.DataAnnotations;

string Mensagem = "Screen Sound";

void ExibirMensagem(){
    Console.WriteLine("************");
    Console.WriteLine(Mensagem);
    Console.WriteLine("************");
    }
    
void ExibirMenu(){
    ExibirMensagem();
    Console.WriteLine("\n1 - Registrar banda");
    Console.WriteLine("2 - Mostrar todas as bandas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir a média de uma banda");
    Console.WriteLine("0 - Para sair");

    Console.Write("\nDigite a sua opção: ");
    string Resposta = Console.ReadLine()!;
    int Resposta1 = int.Parse(Resposta);
    
    switch (Resposta1){
        case 1: criarBanda();
            break;
        case 2: Console.WriteLine("Você digitou a opção " + Resposta1);
            break;
        case 3: Console.WriteLine("Você digitou a opção " + Resposta1);
            break;
        case 4: Console.WriteLine("Você digitou a opção " + Resposta1);
            break;
        case 0: Console.WriteLine("Tchau Tchau :D");
            break;
        default: Console.WriteLine("Você digitou uma opção inválida!");
            break;  
    }
}
// Opções
void criarBanda(){
    Console.Clear();
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirMenu();
}

//

ExibirMenu();