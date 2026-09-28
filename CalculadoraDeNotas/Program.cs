class Program
{
    // FUNÇÕES
    static string cadastrarAluno()
    {
        Console.WriteLine("Digite o nome do aluno: ");
        string nomeAluno = Console.ReadLine();
        return nomeAluno;
    }

    static int[] lancarNotas() {
        int[] notasAluno = new int[3];
        int index = 0;
        while (index < 3) {
            Console.WriteLine((index + 1) + " - " + "Insira a nota do aluno: ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int userNumber))
            {
                if (userNumber <= 10 && userNumber >= 0)
                {
                    notasAluno[index] = userNumber;
                    index++;
                }
                else {
                    Console.WriteLine("Nota inválida");
                }
            }
            else
            {
                Console.WriteLine("Número invalido");
                continue;
            }
        }
        return notasAluno;
    }
    static void calcularMedia() {
        
    }
    static void Main(string[] args)
    {   // VARIÁVEIS
        string nomeAluno;
        bool desligarPrograma = false;
        int[] notasAluno = new int[3];
        double mediaAluno;

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
                    notasAluno = lancarNotas();
                    Console.WriteLine("Notas lançadas!");
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