﻿using System.ComponentModel.DataAnnotations;

string Mensagem = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";
List<string> listaDeBandas = new List<string>{"Neymar","Calypso","DJ Arana"};

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
    int Resposta1 = int.Parse(Resposta);
    
    switch (Resposta1){
        case 1: criarBanda();
            break;
        case 2: mostrarBandas();
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

void tituloOpcao(string titulo){
    Console.WriteLine();
    for(int i = 0; i < titulo.Length; i++){
        Console.Write("*");
    }
    Console.WriteLine();
}

// Opções
void criarBanda(){
    Console.Clear();
    tituloOpcao("Registrar uma Banda");
    Console.Write("Registrar uma Banda");
    tituloOpcao("Registrar uma Banda");
    Console.Write("\nDigite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(1500);
    Console.Clear();
    ExibirMenu();
}
void mostrarBandas(){
    tituloOpcao("Lista de Bandas");
    Console.Write("Lista de Bandas");
    tituloOpcao("Lista de Bandas");
    // for (int i = 0; i < listaDeBandas.Count; i++){
    //     Console.WriteLine($"- {listaDeBandas[i]}");
    // }
    Console.WriteLine();
    foreach (string i in listaDeBandas){
        Console.WriteLine($"- {i}");        
    }
    tituloOpcao("Lista de Bandas");
    Console.WriteLine("\nAperta qualquer tecla para retornar ao menu...");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

//

ExibirMenu();