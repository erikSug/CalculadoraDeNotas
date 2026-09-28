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
    static double calcularMedia(int[] notasAluno) {
        double mediaAluno = 0;
        int totalNota = 0;
        Console.WriteLine("Calculando a média...");
        foreach (int nota in notasAluno) {
            totalNota += nota;
        }
        mediaAluno = totalNota / notasAluno.Length;
        return mediaAluno;
    }

    static void exibirSituacao(double mediaAluno, string nomeAluno) {
        const double MEDIA_APROVACAO = 7.0;
        const double MEDIA_RECUPERACAO = 5.0;
        if (mediaAluno >= MEDIA_APROVACAO)
        {
            Console.WriteLine("O aluno " + nomeAluno + " foi aprovado com a média: " + mediaAluno);
        }
        else if (mediaAluno >= MEDIA_RECUPERACAO)
        {
            Console.WriteLine("O aluno " + nomeAluno + " está de recuperação com a média: " + mediaAluno);
        }
        else {
            Console.WriteLine("O aluno " + nomeAluno + " está reprovado com a média: " + mediaAluno);
        }
    }
    static void Main(string[] args)
    {   // VARIÁVEIS
        string nomeAluno = "";
        bool desligarPrograma = false;
        int[] notasAluno = new int[3];
        double mediaAluno = 0;

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
                    mediaAluno = calcularMedia(notasAluno);
                    exibirSituacao(mediaAluno, nomeAluno);
                    break;
                case 4:
                    Console.WriteLine("Desligando o programa...");
                    desligarPrograma = true;
                    Console.WriteLine("Até a próxima!");
                    break;
                default:
                    Console.WriteLine("Comando não encontrado");
                    break;
            }

        }
    }
}