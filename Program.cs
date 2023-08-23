using System.ComponentModel.DataAnnotations;
using System.Globalization;

string Mensagem = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";
// List<string> listaDeBandas = new List<string>{"Neymar","Calypso","DJ Arana"};
Dictionary<string, List<int>> listaDeBandas = new Dictionary<string, List<int>>();
listaDeBandas.Add("Neymar",new List<int>{10, 8, 6});
listaDeBandas.Add("Calypso",new List<int>{5, 0 ,2});
listaDeBandas.Add("DJ Arana",new List<int>());

void ExibirMensagem(){
    Console.WriteLine(Mensagem);
    }
    
void ExibirMenu(){
    Console.Clear();
    ExibirMensagem();
    Console.WriteLine("\n1 - Registrar banda");
    Console.WriteLine("2 - Mostrar todas as bandas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir a média de uma banda");
    Console.WriteLine("0 - Para sair");

    Console.Write("\nDigite a sua opção: ");
    string Resposta = Console.ReadLine()!;
    int RespostaNum = int.Parse(Resposta);
    
    switch (RespostaNum){
        case 1: criarBanda();
            break;
        case 2: mostrarBandas();
            break;
        case 3: avaliarBandas();
            break;
        case 4: Console.WriteLine("Você digitou a opção " + RespostaNum);
            break;
        case 0: Console.WriteLine("Tchau Tchau :D");
            break;
        default: Console.WriteLine("\nVocê digitou uma opção inválida! Tente novamente..");
                Thread.Sleep(2000);
                ExibirMenu();
            break;  
    }
}

void tituloOpcao(string titulo){
    for(int i = 0; i < titulo.Length; i++){
        Console.Write("*");
    }
    Console.Write("\n" + titulo + "\n");
    for(int i = 0; i < titulo.Length; i++){
        Console.Write("*");
    }
    Console.WriteLine();
}

// Opções

//Opção 1
void criarBanda(){
    Console.Clear();
    tituloOpcao("Registrar uma Banda");
    Console.Write("\nDigite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeBanda,new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(1500);
    Console.Clear();
    ExibirMenu();
}
//Opção 2
void mostrarBandas(){
    Console.Clear();
    tituloOpcao("Lista de Bandas");
    // for (int i = 0; i < listaDeBandas.Count; i++){
    //     Console.WriteLine($"- {listaDeBandas[i]}");
    // }
    Console.WriteLine();
    foreach (string i in listaDeBandas.Keys){
        Console.WriteLine($"- {i}");        
    }

    Console.WriteLine("\nAperta qualquer tecla para retornar ao menu...");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}
//Opção 3
void avaliarBandas(){
    Console.Clear();
    tituloOpcao("Avaliar Banda");
    int num = 0;
    foreach(string i in listaDeBandas.Keys){
        num++;
        Console.WriteLine($"{num} - {i}");
    }
    Console.Write("Digite a opção: ");
    string escolhaBanda = Console.ReadLine()!;
    int respostaBanda = int.Parse(escolhaBanda);
    if (respostaBanda < listaDeBandas.Keys.Count+1 & respostaBanda > 0){
        //voce precisa adicionar um switch que selecione a banda que deseja ser avaliada
    }else{
        Console.WriteLine("Wrong");
    }

}

//

ExibirMenu();