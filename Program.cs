using System; 


namespace AnalyzerGenshin
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        static public int Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("===============================");
            Console.ResetColor();
            Console.WriteLine(" Menu       Analizador Genshin");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("===============================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("[1] Cadastrar Personagem");
            Console.WriteLine("[2] Cadastrar Artefato");
            Console.WriteLine("[3] Listar Personagens");
            Console.WriteLine("[4] Listar Artefatos");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[0] Sair");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Digite:");
            int M = -1;
            try
            {
                M = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("===============================");
                Console.ResetColor();
                
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Erro, Tente denovo.");
                Console.ResetColor();
            }
            if (M != -1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("===============================");
                Console.ResetColor();
            }
            
            return M;
        }
    }
}
