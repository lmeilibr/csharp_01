namespace csharp_01;

public class Programas
{
    public static void Ex01()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
    }

    public static void Ex02()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome:");
        string sobrenome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome} {sobrenome}! Seja muito bem-vindo!");
    }


    public static (double, double, double, double, double) Ex03()
    {
        Console.WriteLine("Digite um número real:");
        double numero = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite outro número real:");
        double numero2 = Convert.ToDouble(Console.ReadLine());
        if (numero2 == 0)
        {
            Console.WriteLine("Divisão por zero não é permitida.");
            return (0, 0, 0, 0, 0);
        }

        double soma = numero + numero2;
        double subtracao = numero - numero2;
        double multiplicacao = numero * numero2;
        double divisao = numero / numero2;
        double media = (numero + numero2) / 2;

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão: {divisao}");
        Console.WriteLine($"Média: {media}");

        return (soma, subtracao, multiplicacao, divisao, media);
    }

    public static void Ex04()
    {
        Console.WriteLine("Digite uma ou mais palavras:");
        string input = Console.ReadLine();
        int quantidadeCaracteres = input.Length;
        Console.WriteLine($"A quantidade de caracteres é: {quantidadeCaracteres}");
        int quantidadeCaracteresSemEspaco = input.Replace(" ", "").Length;
        Console.WriteLine($"A quantidade de caracteres sem espaços é: {quantidadeCaracteresSemEspaco}");
    }

    public static void Ex05()
    {
        Console.WriteLine("Digite a placa de um veículo (formato ABC1234):");
        string placa = Console.ReadLine().ToUpper();
        // use regex to validate the plate format
        if (System.Text.RegularExpressions.Regex.IsMatch(placa, "^[A-Z]{3}[0-9]{4}$"))
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
    }

    public static void Ex06()
    {
        Console.WriteLine("Escolha uma das 4 opções (1-4) para ver a data de hoje:");
        /*
         * 1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
           2 - Apenas a data no formato "01/03/2024".
           3 - Apenas a hora no formato de 24 horas.
           4 - A data com o mês por extenso.
         */
        string escolha = Console.ReadLine();
        DateTime agora = DateTime.Now;
        switch (escolha)
        {
            case "1":
                Console.WriteLine(agora.ToString("F"));
                break;
            case "2":
                Console.WriteLine(agora.ToString("dd/MM/yyyy"));
                break;
            case "3":
                Console.WriteLine(agora.ToString("HH:mm:ss"));
                break;
            case "4":
                Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy"));
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}