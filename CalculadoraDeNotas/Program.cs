class Program
{
    // FUNÇÕES
    static string cadastrarAluno()
    {
        Console.WriteLine("Digite o nome do aluno: ");
        string nomeAluno = Console.ReadLine();
        return nomeAluno;
    }
    static void Main(string[] args)
    {   // VARIÁVEIS
        string nomeAluno;
        bool desligarPrograma = false;

        // PROGRAMA PRINCIPAL
        while (!desligarPrograma) {
            Console.WriteLine("");
            Console.WriteLine("====Calculadora de Notas====");
            Console.WriteLine("Olá, o que gostaria de fazer: ");
            Console.WriteLine("1 - Cadastrar Aluno.");
            Console.WriteLine("2 - Lançar notas.");
            Console.WriteLine("3 - Calcular média.");
            Console.WriteLine("4 - Sair");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int userNumber))
            {
            }
            else
            {
                Console.WriteLine("Comando não encontrado");
                continue;
            }

            /// LÓGICA DE ESCOLHAS
            switch (userNumber) {
                case 1:
                    nomeAluno = cadastrarAluno();
                    Console.WriteLine("Aluno " + nomeAluno + " adicionado!");
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Console.WriteLine("Até a próxima!");
                    desligarPrograma = true;
                    break;
                default:
                    Console.WriteLine("Comando não encontrado");
                    break;
            
            
            }

        }
    }
}