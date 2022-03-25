using System; 


namespace AnalyzerGenshin
{
    class Program
    {
        static void Main()
        {
            int run;
            do
            {
                run = Menu();
                switch (run)
                {
                    case 1: CadastrarPersonagem() ;break;
                    case 2: CadastrarArtefato()   ;break;

                }

            } while (run != 0);
            
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
        static public void CadastrarPersonagem()
        {
            try
            {
                string nome;
                int level, id;

                Console.WriteLine("Informaçoes do Seu Personagem:");
                Console.WriteLine();
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Nome: ");

                nome = Console.ReadLine();

                Console.WriteLine();
                Console.Write("Level: ");

                level = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Tipo:");
                Console.WriteLine();
                Console.WriteLine("[1] Hydro");
                Console.WriteLine("[2] Pyro");
                Console.WriteLine("[3] Cryo");
                Console.WriteLine("[4] Electro");
                Console.WriteLine("[5] Geo");
                Console.WriteLine("[6] Anemo");
                Console.WriteLine();
                Console.Write("Digite: ");
                int TipoC = int.Parse(Console.ReadLine());

                string tipo;
                tipo = "Default";

                if (TipoC == 1) tipo = "Hydro";
                if (TipoC == 2) tipo = "Pyro";
                if (TipoC == 3) tipo = "Cryo";
                if (TipoC == 4) tipo = "Electro";
                if (TipoC == 5) tipo = "Geo";
                if (TipoC == 6) tipo = "Anemo";

                Personagem p = new Personagem(id, level, nome, tipo, 1, 2, 3, 4);
                Sistema.PersonagemInserir(p);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Personagem Cadastrado!");
                Console.ResetColor();
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Erro, Tente denovo.");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        static public void CadastrarArtefato()
        {
            try
            {
                string nome, tipo, mainStatus, status1, status2, status3, status4;
                int id, valorMainStatus, valorStatus1, valroStatus2, valorStatus3, valroStatus4;

                Console.WriteLine("Informaçoes do Seu Personagem:");
                Console.WriteLine();
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Nome: ");

                nome = Console.ReadLine();

                Console.WriteLine();
                Console.Write("Tipo: ");
                Console.WriteLine();
                Console.WriteLine("[1] Flor");
                Console.WriteLine("[2] Pena");
                Console.WriteLine("[3] Relogio");
                Console.WriteLine("[4] Cálice");
                Console.WriteLine("[5] Tiara");
                Console.WriteLine();
                
                int idTipo;
                do
                {
                    Console.Write("Digite:");
                    idTipo = int.Parse(Console.ReadLine());
                }while (idTipo > 5 || idTipo < 0);

                switch (idTipo)
                {
                    case 1: tipo = "FLOR"; mainStatus = "HP FLAT"; break;
                    case 2: tipo = "PENA"; mainStatus = "ATQ FLAT"; break;
                    case 3: tipo = "RELOGIO"; break;
                    case 4: tipo = "CÁLICE" ; break;
                    case 5: tipo = "TIARA"  ; break;
                }
                
                if (idTipo != 1 || idTipo != 2)
                {
                    Console.WriteLine();
                    Console.Write("Main Status: ");
                    Console.WriteLine("[1] HP%");
                    Console.WriteLine("[2] ATQ%");
                    Console.WriteLine("[3] DEF%");
                    Console.WriteLine("[4] Crit RATE");
                    Console.WriteLine("[5] Crit DMG");
                    Console.WriteLine("[6] Elemental Mastery");
                    Console.WriteLine("[7] Energy Recharge");
                    Console.WriteLine("[8] Healing Bonus");
                    Console.WriteLine("[9] Elemental DMG");
                    Console.WriteLine("[10] Phisical DMG");
                    Console.WriteLine();
                    
                    int idMainStatus;
                    do
                    {
                        Console.Write("Digite:");
                        idMainStatus = int.Parse(Console.ReadLine());
                    }while (idMainStatus > 10 || idMainStatus < 0);

                    switch (idMainStatus)
                    {
                        case 1: mainStatus = "HP%"   ; break;
                        case 2: mainStatus = "ATQ%"   ; break;
                        case 3: mainStatus = "DEF%"; break;
                        case 4: mainStatus = "CRIT RATE" ; break;
                        case 5: mainStatus = "CRIT DMG"  ; break;
                        case 6: mainStatus = "Elemental Mastery"   ; break;
                        case 7: mainStatus = "Energy Recharge"   ; break;
                        case 8: mainStatus = "Healing Bonus"; break;
                        case 9: mainStatus = "Elemental DMG" ; break;
                        case 10: mainStatus = "Phisical DMG"  ; break;
                    }
                }

                status1 = Status(1);
                status2 = Status(2);
                status3 = Status(3);
                status4 = Status(4);
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Erro, Tente denovo.");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        static public string Status(int nmr)
        {
            Console.WriteLine();
            Console.Write($"Status{nmr}: ");
            Console.WriteLine("[1] HP%");
            Console.WriteLine("[2] ATQ%");
            Console.WriteLine("[3] DEF%");
            Console.WriteLine("[4] Crit RATE");
            Console.WriteLine("[5] Crit DMG");
            Console.WriteLine("[6] Elemental Mastery");
            Console.WriteLine("[7] Energy Recharge");
            Console.WriteLine("[8] HP FLAT");
            Console.WriteLine("[9] DEF FLAT");
            Console.WriteLine("[10] ATQ FLAT");
            Console.WriteLine();

            string tipo;
            tipo = "Default";
            int idStatus;
                do
                {
                    Console.Write($"Digite Status{nmr}:");
                    idStatus = int.Parse(Console.ReadLine());
                }while (idStatus > 10 || idStatus < 0);

                switch (idStatus)
                {
                    case 1: tipo = "HP%"   ; break;
                    case 2: tipo = "ATQ%"   ; break;
                    case 3: tipo = "DEF%"; break;
                    case 4: tipo = "CRIT RATE" ; break;
                    case 5: tipo = "CRIT DMG"  ; break;
                    case 6: tipo = "Elemental Mastery"   ; break;
                    case 7: tipo = "Energy Recharge"   ; break;
                    case 8: tipo = "HP FLAT"; break;
                    case 9: tipo = "DEF FLAT" ; break;
                    case 10: tipo = "ATQ FLAT"  ; break;
                }
            return tipo;
        }
    }
}