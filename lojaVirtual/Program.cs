// See https://aka.ms/new-console-template for more information

using System.Drawing;

string codProd;
string resp;
double total = 0;

string[] produto = new string[5]
{
    "[1] Camisa    ","[2] Camiseta  ","[3] Calça     ","[4] Bermuda   ","[5] Sapato    "
};

double[] preco = new double[5] { 45.99,35.55,55.99,30.99,60.55};

static void Logo()
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("   L O J Ã O    D O     J O R J Ã O   ");
    Console.WriteLine("----------------------------------------");
}
static void display(string[] produto, double[] preco)
{
    Console.WriteLine(produto[0] + preco[0]);
    Console.WriteLine(produto[1] + preco[1]);
    Console.WriteLine(produto[2] + preco[2]);
    Console.WriteLine(produto[3] + preco[3]);
    Console.WriteLine(produto[4] + preco[4]);
}

Logo();
display(produto, preco);


    do
    {
        Console.Write("Insira o código do produto desejado: ");
        codProd = Console.ReadLine();

    switch (codProd)
    {
        case "1":
            Console.Clear();
            total += preco[0];
            Console.WriteLine("Produto adicionado!");
            Logo();
            display(produto, preco);

            break;
        
        case "2":

            Console.Clear();
            total += preco[1];
            Console.WriteLine("Produto adicionado!");
            Logo();
            display(produto, preco);
            break;
       
        case "3":

            Console.Clear();
            total += preco[2];
            Console.WriteLine("Produto adicionado!");
            Logo();
            display(produto, preco);
            break;
        
        case "4":

            Console.Clear();
            total += preco[3];
            Console.WriteLine("Produto adicionado!");
            Logo();
            display(produto, preco);
            break;

        case "5":

            Console.Clear();
            total += preco[4];
            Console.WriteLine("Produto adicionado!");
            Logo();
            display(produto, preco);
            break;

        default: Console.WriteLine("Opção inválida!");
            
            break;
    }
        
        Console.WriteLine("Deseja adicionar mais itens?");
        resp = Console.ReadLine();
    Console.Clear();
    Logo();
    display(produto, preco);


} while (resp == "sim");

Console.Clear();

if(total >= 100.00)
{
    Console.WriteLine("Você ganhou um desconto de 10%");
  

    double disconto = 10.00 * total;
    double ValorDisc = disconto / 100;
    double valorFinal = total - ValorDisc;
    Console.WriteLine("O valor foi atualizado de R$" + String.Format("{0:00.00}", total) + " para R$" + String.Format("{0:00.00}", valorFinal));
}
else
{
    Console.WriteLine("O total da suas compras foram de R$" + String.Format("{0:00.00}", total));
}

Console.WriteLine("Obrigado pela preferência, volte sempre!");

Console.ReadKey();