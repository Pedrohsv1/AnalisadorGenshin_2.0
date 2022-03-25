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
                    case 3: PersonagemListarNome();break;

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
                Console.WriteLine("================================");
                Console.ResetColor();
                
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Erro, Tente denovo.");
                Console.ResetColor();
            }
            if (M != -1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("================================");
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

                Console.WriteLine("-=-= Cadastro do Personagem =-=-");
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

                {
                    Console.Write("[1] ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Hidro");
                    Console.ResetColor();
                    Console.Write("[2] ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Pyro");
                    Console.ResetColor();
                    Console.Write("[3] ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Cryo");
                    Console.ResetColor();
                    Console.Write("[4] ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Electro");
                    Console.ResetColor();
                    Console.Write("[5] ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Geo");
                    Console.ResetColor();
                    Console.Write("[6] ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Anemo");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                
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
                string nome, tipo = "Default", mainStatus = "Default", status1, status2, status3, status4;
                int id;
                double valorMainStatus, valorStatus1, valorStatus2, valorStatus3, valorStatus4;

                Console.WriteLine("=-=-= Cadastro do Artefato =-=-=");
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
                
                Console.WriteLine(idTipo);
                if (idTipo > 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Main Status: ");
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
                if ( idTipo == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Flor é unicamente VIDA FLAT.");
                    Console.WriteLine();
                }
                if ( idTipo == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Pena é unicamente ATQ FLAT.");
                    Console.WriteLine();
                }

                status1 = Status(1);
                status2 = Status(2);
                status3 = Status(3);
                status4 = Status(4);

                Console.WriteLine();
                Console.Write($"Valor Main Status {mainStatus}: ");
                valorMainStatus = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write($"Valor Status 1 {status1}: ");
                valorStatus1 = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write($"Valor Status 2 {status2}: ");
                valorStatus2 = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write($"Valor Status 3 {status3}: ");
                valorStatus3 = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write($"Valor Status 4 {status4}: ");
                valorStatus4 = double.Parse(Console.ReadLine());

                Artefato a = new Artefato(id, nome, tipo, mainStatus, status1, status2, status3, status4, valorMainStatus, valorStatus1, valorStatus2, valorStatus3, valorStatus4);
                Sistema.ArtefatoInserir(a);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Artefato Cadastrado!");
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
        static public string Status(int nmr)
        {
            Console.WriteLine();
            Console.WriteLine($"Status {nmr}: ");
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
                    Console.Write($"Digite Status {nmr}:");
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
        static public void PersonagemListarNome()
        {
            foreach(Personagem p in Sistema.PersonagemListar())
            {
                Console.WriteLine();
                Console.WriteLine(p);
            }
        }
    }
}