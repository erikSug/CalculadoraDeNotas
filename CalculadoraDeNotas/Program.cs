class Program
{
    static void Main()
    {
        // VARIÁVEIS
        string nomeAluno;
        bool desligarPrograma = false;
        void cadastrarAluno() {
            Console.WriteLine("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine();
        }
        // PROGRAMA PRINCIPAL
        while (!desligarPrograma) {
            Console.WriteLine("Olá, o que gostaria de fazer: ");
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
            }
            switch (userNumber) {
                case 1:
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
                    break;
            
            
            }

        }
    }
}