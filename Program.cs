// See https://aka.ms/new-console-template for more information

bool progLigado = true;

int[] carrinho;
carrinho = new int[3];
carrinho[0] = 0;
carrinho[1] = 0;
carrinho[2] = 0;

void Continuar()
{
    Console.Clear();
    Console.WriteLine($"O Carrinho contém {carrinho[0]} Doce1, {carrinho[1]} Doce 2 e {carrinho[2]} Doce3, Deseja adicionar mais algum doce? [S/N]");
    string progLigadostr = (Console.ReadLine());
    bool menuFinal = true;
    while (menuFinal) {
        if (progLigadostr == "N")
        {
            progLigado = false;
            menuFinal = false;
            Console.WriteLine($"Seu Carrinho contém {carrinho[0]} Doce1, {carrinho[1]} Doce 2 e {carrinho[2]} Doce3, foi uma otima compra, boa noite");
        }
        else if (progLigadostr == "S")
        {
            menuFinal = false;
            Console.WriteLine("Ótimo! Vamos continuar as compras");
        }
        else
        {
            Console.WriteLine("Você não digitou nenhuma das opções fornecidas, deseja voltar [S/N]?");
            progLigadostr = (Console.ReadLine());
        }
    }
}


Console.WriteLine("Olá bem vindo a padaria LDP! O que deseja?");
while (progLigado) { 
Console.WriteLine("1 - Doce1");
Console.WriteLine("2 - Doce2");
Console.WriteLine("3 - Doce3");
    Console.WriteLine("Digite o numero do seu doce e pressione enter");
    var escolhaDoce = Console.ReadLine();
    switch (escolhaDoce)
    {
        case "1":
            Console.WriteLine("Voce escolheu o Doce1");
            Console.WriteLine("Digite a quantidade de desejada desse tipo de doce");
            try {
                carrinho[0] += Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Essa quantia não é valida");
                Thread.Sleep(3000);
                Console.Clear();
                break;
            }
            Continuar();
            break;

        case "2":
            Console.WriteLine("Voce escolheu o Doce2");
            Console.WriteLine("Digite a quantidade de desejada desse tipo de doce");
            try
            {
                carrinho[1] += Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Essa quantia não é valida");
                Thread.Sleep(3000);
                Console.Clear();
                break;
            }
            Continuar();
            break;

        case "3":
            Console.WriteLine("Voce escolheu o Doce3");
            Console.WriteLine("Digite a quantidade de desejada desse tipo de doce");
            try
            {
                carrinho[2] += Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Essa quantia não é valida");
                Thread.Sleep(3000);
                Console.Clear();
                break;
            }
            Continuar();
            break;

        default:
            Console.WriteLine("Esse doce não é valido");
            Thread.Sleep(3000);
            Console.Clear();
            break;
    }
    
}
