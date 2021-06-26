using System; 
class minhaClasse {
    static void Main(string[] args) { 

            Console.WriteLine("Informe a quantidade de testes: ");
            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;

            for (int i = 1; i <= qtdTeste; i++)
            {
                Console.WriteLine("Informe a escolha de Sheldon e Raj, respectivamente: ");
                string[] escolha = Console.ReadLine().Split();
                v1 = escolha[0];
                v2 = escolha[1];
                if((v1 == "tesoura" && v2 == "papel") || (v1 == "papel" && v2 == "pedra")
                    || (v1 == "pedra" && v2 == "lagarto") || (v1 == "lagarto" && v2 == "Spock")
                    || (v1 == "Spock" && v2 == "tesoura") || (v1 == "tesoura" && v2 == "lagarto")
                    || (v1 == "lagarto" && v2 == "papel") || (v1 == "papel" && v2 == "Spock")
                    || (v1 == "Spock" && v2 == "pedra") || (v1 == "pedra" && v2 == "tesoura"))
                {
                    Console.WriteLine("Caso #{0}: Bazinga!", i);  
                }  
                else if (v1 == v2)
                {
                    Console.WriteLine("Caso #{0}: De novo!", i);
                }
                else
                {
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
                }                    
            }
    }
}