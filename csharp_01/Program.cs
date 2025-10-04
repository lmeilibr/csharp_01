// See https://aka.ms/new-console-template for more information

using csharp_01;

while (true){
Console.WriteLine("Escolha o programa que deseja executar (1-6) ou 0 para sair:");
string escolha = Console.ReadLine();

    switch (escolha)
    {
        case "0":
            return;
        case "1":
            Programas.Ex01();
            break;
        case "2":
            Programas.Ex02();
            break;
        case "3":
            Programas.Ex03();
            break;
        case "4":
            Programas.Ex04();
            break;
        case "5":
            Programas.Ex05();
            break;
        case "6":
            Programas.Ex06();
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}
