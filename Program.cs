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
                    case 3: MenuPersonagem()      ;break;
                    case 4: ArtfeatoListarNome()  ;break;

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
                int level, id, idArtefato1, idArtefato2, idArtefato3, idArtefato4, idArtefato5;

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

                while(TipoC < 1 || TipoC > 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Tente digitar outro número");
                    Console.ResetColor();
                    Console.Write("Digite:");
                    TipoC = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();

                string tipo;
                tipo = "Default";

                if (TipoC == 1) tipo = "Hydro";
                if (TipoC == 2) tipo = "Pyro";
                if (TipoC == 3) tipo = "Cryo";
                if (TipoC == 4) tipo = "Electro";
                if (TipoC == 5) tipo = "Geo";
                if (TipoC == 6) tipo = "Anemo";                

                idArtefato1 = CadastrarArtefatoPersonagem( "FLOR", 1);
                idArtefato2 = CadastrarArtefatoPersonagem( "PENA", 2);
                idArtefato3 = CadastrarArtefatoPersonagem( "RELOGIO", 3);
                idArtefato4 = CadastrarArtefatoPersonagem( "CÁLICE", 3);
                idArtefato5 = CadastrarArtefatoPersonagem( "TIARA", 3);

                Personagem p = new Personagem(id, level, nome, tipo, idArtefato1, idArtefato2, idArtefato3, idArtefato4, idArtefato5);
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
        static public void CadastrarArtefato( string i = "Default" , int j = 0)
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

                if(i == "Default")
                {
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
                }
                else
                {
                    tipo = i;
                    if (j == 3)
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
                    if ( j == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Flor é unicamente VIDA FLAT.");
                    }
                    if ( j == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Pena é unicamente ATQ FLAT.");
                    }
                }

                status1 = Status(1);
                status2 = Status(2);
                status3 = Status(3);
                status4 = Status(4);


                Console.Write($"Valor Main Status {mainStatus}: ");
                valorMainStatus = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write($"Valor SubStatus 1 {status1}: ");
                valorStatus1 = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write($"Valor SubStatus 2 {status2}: ");
                valorStatus2 = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write($"Valor SubStatus 3 {status3}: ");
                valorStatus3 = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write($"Valor SubStatus 4 {status4}: ");
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
        static public void AtualizarPersonagem(Personagem p)
        {
            string tipo = "Default", nome = "Default";
            int id = 0, level = 0;
            try
            {
                Console.WriteLine("-=-= Atualizar o Personagem =-=-");
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
                    Console.WriteLine("Hydro");
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
                int DadoTipo = int.Parse(Console.ReadLine());

                while(DadoTipo < 1 || DadoTipo > 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Tente digitar outro número");
                    Console.ResetColor();
                    Console.Write("Digite:");
                    DadoTipo = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                if (DadoTipo == 1) tipo = "Hydro";
                if (DadoTipo == 2) tipo = "Pyro";
                if (DadoTipo == 3) tipo = "Cryo";
                if (DadoTipo == 4) tipo = "Electro";
                if (DadoTipo == 5) tipo = "Geo";
                if (DadoTipo == 6) tipo = "Anemo";
            }
            catch(Exception)
            {
                AtualizarPersonagem(p);
            }         

            p.SetNome(nome);
            p.SetId(id);
            p.SetLevel(level);
            p.SetTipo(tipo);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Personagem Atuliazado!");
            Console.ResetColor();
            Console.WriteLine();
        }
        static public void NomePersonagem(Personagem p)
        {
            Console.WriteLine("-=-= Personagem Nome =-=-");
            try
            {
                Console.WriteLine("Digite: ");
                string nome =Console.ReadLine();
                p.SetNome(nome);
            }
            catch(Exception)
            {
                NomePersonagem(p);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Nome Atuliazado!");
            Console.ResetColor();
            Console.WriteLine();
        }
        static public void LevelPersonagem(Personagem p)
        {
            Console.WriteLine("-=-= Personagem Level =-=-");
            try
            {
                Console.WriteLine("Digite: ");
                int level = int.Parse(Console.ReadLine());
                p.SetLevel(level);
            }
            catch(Exception)
            {
                LevelPersonagem(p);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Level Atuliazado!");
            Console.ResetColor();
            Console.WriteLine();
        }
        static public void IdPersonagem(Personagem p)
        {
            Console.WriteLine("-=-= Personagem Id =-=-");
            try
            {
                Console.WriteLine("Digite: ");
                int id = int.Parse(Console.ReadLine());
                p.SetId(id);
            }
            catch(Exception)
            {
                IdPersonagem(p);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Level Atuliazado!");
            Console.ResetColor();
            Console.WriteLine();
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
        static public void MenuPersonagem()
        {         
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("===============================");
            Console.ResetColor();
            Console.WriteLine(" Menu               Personagem");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("===============================");
            Console.ResetColor();
            Console.WriteLine();   
            try
            {
                int i = 1;
                foreach(Personagem p in Sistema.PersonagemListar())
                {
                    Console.WriteLine();
                    Console.WriteLine($"[{i}] {p.GetNome()}");
                    i++;
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[0] Voltar");
                Console.ResetColor();
                int escolhaPersonagem = -1;
                
                while(escolhaPersonagem == -1)
                {
                    i = 1;
                    Console.WriteLine();
                    Console.WriteLine("Digite:");
                    escolhaPersonagem = int.Parse(Console.ReadLine());
                    
                    if(escolhaPersonagem == 0) break;
                    foreach(Personagem p in Sistema.PersonagemListar())
                    {
                        if(i == escolhaPersonagem)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("===============================");
                            Console.ResetColor();
                            MenuSubPersonagem(p);
                        }
                        else
                        {
                            escolhaPersonagem = -1;
                        }
                        i++;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("===============================");
                Console.ResetColor();
            }
            catch(Exception)
            {
                MenuPersonagem();
            }
            
        }
        static public void MenuSubPersonagem(Personagem p)
        {
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{p.GetNome()}");
            Console.ResetColor();
            Console.WriteLine($" - TIPO : {p.GetTipo()} - ID : {p.GetId()}");
            Console.WriteLine();
            Console.WriteLine("[1] Mudar Dados");
            Console.WriteLine("[2] Artefatos");
            Console.WriteLine("[3] Listar Dados");
            Console.Write("[4] ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Excluir");
            Console.WriteLine("[0] Voltar");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Digite:");
            int escolhaSubPersonagem = int.Parse(Console.ReadLine());
            try
            {
                while(escolhaSubPersonagem < 0 || escolhaSubPersonagem > 4)
                {
                    Console.WriteLine("Erro tente novamente, Digite:");
                    escolhaSubPersonagem = int.Parse(Console.ReadLine());
                }
                
            }
            catch(Exception)
            {
                MenuSubPersonagem(p);
            }
            if(escolhaSubPersonagem == 0)
            {
                MenuPersonagem();
            }
            switch( escolhaSubPersonagem )
            { 
                case 1: MenuMudarDados(p); break;
                case 2: MenuPersonagemArtefato(p); break;
                case 3: Console.WriteLine(p); MenuSubPersonagem(p); break;
                case 4: Sistema.PersonagemExcluir(p); break;
            }
        }
        static public void MenuMudarDados(Personagem p)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{p.GetNome()}");
            Console.ResetColor();
            Console.WriteLine($" - TIPO : {p.GetTipo()} - ID : {p.GetId()}");
            Console.WriteLine();
            Console.WriteLine("[1] Reset");
            Console.WriteLine("[2] Mudar o Nome");
            Console.WriteLine("[3] Mudar o ID");
            Console.WriteLine("[4] Mudar o Level");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[0] Voltar");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Digite:");
            int escolhaMudarDados = int.Parse(Console.ReadLine());
            try
            {
                while(escolhaMudarDados < 0 || escolhaMudarDados > 4)
                {
                    Console.WriteLine("Erro tente novamente, Digite:");
                    escolhaMudarDados = int.Parse(Console.ReadLine());
                }
                
            }
            catch(Exception)
            {
                MenuMudarDados(p);
            }
            switch(escolhaMudarDados)
            {
                case 0: MenuSubPersonagem(p); break;
                case 1: AtualizarPersonagem(p); MenuMudarDados(p); break;
                case 2: NomePersonagem(p); MenuMudarDados(p); break;
                case 3: IdPersonagem(p); MenuMudarDados(p); break;
                case 4: LevelPersonagem(p); MenuMudarDados(p); break;
            }
        }
        static public void MenuPersonagemArtefato(Personagem p)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{p.GetNome()}");
            Console.ResetColor();
            Console.WriteLine($" - TIPO : {p.GetTipo()} - ID : {p.GetId()}");
            Console.WriteLine();
            Console.WriteLine("[1] Mostrar tudo");
            Console.WriteLine("[2] Pena");
            Console.WriteLine("[3] Flor");
            Console.WriteLine("[4] Relogio");
            Console.WriteLine("[5] Cálice");
            Console.WriteLine("[6] Tiara");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[0] Voltar");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Digite:");
            int escolhaPersonagemArtefato = int.Parse(Console.ReadLine());
            try
            {
                while(escolhaPersonagemArtefato < 0 || escolhaPersonagemArtefato > 6)
                {
                    Console.WriteLine("Erro tente novamente, Digite:");
                    escolhaPersonagemArtefato = int.Parse(Console.ReadLine());
                }
                
            }
            catch(Exception)
            {
                MenuMudarDados(p);
            }
            switch(escolhaPersonagemArtefato)
            {
                case 0: MenuSubPersonagem(p); break;
                case 1: ArtfeatosListarPersonagem(p); MenuPersonagemArtefato(p); break;
                case 2:  MenuSubPersonagemArtefato( p, "PENA"); break;
                case 3:  MenuSubPersonagemArtefato( p, "FLOR"); break;
                case 4:  MenuSubPersonagemArtefato( p, "RELOGIO"); break;
                case 5:  MenuSubPersonagemArtefato( p, "CÁLICE"); break;
                case 6:  MenuSubPersonagemArtefato( p, "TIARA"); break;
            }
        }
        static public void MenuSubPersonagemArtefato(Personagem p, string s)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{p.GetNome()}");
            Console.ResetColor();
            Console.WriteLine($" - TIPO : {p.GetTipo()} - ID : {p.GetId()}");
            Console.WriteLine();
            Console.WriteLine($"{s}");
            Console.WriteLine();
            Console.WriteLine($"[1] Mostrar");
            Console.WriteLine("[2] Trocar");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[0] Voltar");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Digite:");
            int escolhaPersonagemArtefato = int.Parse(Console.ReadLine());
            try
            {
                while(escolhaPersonagemArtefato < 0 || escolhaPersonagemArtefato > 2)
                {
                    Console.WriteLine("Erro tente novamente, Digite:");
                    escolhaPersonagemArtefato = int.Parse(Console.ReadLine());
                }
                
            }
            catch(Exception)
            {
                MenuSubPersonagemArtefato(p, s);
            }
            int x = 1;
            int id = -1;
            if(s == "FLOR")
            {
                id = p.GetIdArtefato1();
            }
            else
            {
                if(s == "PENA")
                {
                    x = 2;
                    id = p.GetIdArtefato2();
                }
                else
                {
                    if(s == "RELOGIO")
                    {
                        x = 3;
                        id = p.GetIdArtefato3();
                    }
                    else
                    {
                        if(s == "CÁLICE")
                        {
                            x = 3;
                            id = p.GetIdArtefato4();
                        }
                        else
                        {
                            if(s == "TIARA")
                            {
                                x = 3;
                                id = p.GetIdArtefato5();
                            }
                        }
                    }
                }
            }
            
            switch(escolhaPersonagemArtefato)
            {
                case 0: MenuPersonagemArtefato(p); break;
                case 1: Console.WriteLine(BuscarArtefato(id)); MenuSubPersonagemArtefato(p, s); break;
                case 2: TrocarArtefatoPersonagem(p, s, x); MenuSubPersonagemArtefato(p, s); break;
            }
        }
        static public void ArtfeatoListarNome()
        {
            foreach(Artefato a in Sistema.ArtefatoListar())
            {
                Console.WriteLine(a);
                Console.WriteLine();
            }
        }
        static public void ArtfeatosListarPersonagem(Personagem p)
        {
            int[] IDs = new int[5];

            IDs[0] = p.GetIdArtefato1();
            IDs[1] = p.GetIdArtefato2();
            IDs[2] = p.GetIdArtefato3();
            IDs[3] = p.GetIdArtefato4();
            IDs[4] = p.GetIdArtefato5();

            foreach(int i in IDs)
            {
                foreach(Artefato a in Sistema.ArtefatoListar())
                {
                    if(a.GetId() == i)
                    {
                        Console.WriteLine(a);
                        Console.WriteLine();
                    }
                }
            }
        }
        static public int CadastrarArtefatoPersonagem( string s, int r)
        {
            int i = 0;
            int Id;
            foreach(Artefato a in Sistema.ArtefatoListar())
            {
                if(a.GetTipo() == s)
                {
                    Console.WriteLine(a);
                    i++;
                }
            }
            if( i == 0 )
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Cadatre uma {s} no menu você");
                Console.WriteLine("não possui uma ainda!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine($"Deseja cadastar uma {s}? [s/n] ");
                Console.Write("Digite:");
                string j = Console.ReadLine();
                while(j != "s" && j != "n")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Tente digitar [s/n].");
                    Console.ResetColor();
                    Console.Write("Digite:");
                    j = Console.ReadLine();
                }
                if(j == "s")
                {
                    CadastrarArtefato(s, r);
                    foreach( Artefato a in Sistema.ArtefatoListar() )
                    {
                        if( a.GetTipo() == s )
                        {
                            Console.WriteLine();
                            Console.WriteLine(a);
                            Console.WriteLine();
                        }
                    }
                    Console.Write("Digite o ID do artefato: ");
                    Id = int.Parse(Console.ReadLine());
                    return Id;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                Console.Write("Digite o ID do artefato: ");
                Id = int.Parse(Console.ReadLine());
                return Id;
                
            }
            
        }
        static public void TrocarArtefatoPersonagem(Personagem p, string s, int r)
        {
            int i = 0;
            int Id;
            foreach(Artefato a in Sistema.ArtefatoListar())
            {
                if(a.GetTipo() == s)
                {
                    Console.WriteLine(a);
                    i++;
                }
            }
            if( i == 0 )
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Cadatre uma {s} no menu você");
                Console.WriteLine("não possui uma ainda!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine($"Deseja cadastar uma {s}? [s/n] ");
                Console.Write("Digite:");
                string j = Console.ReadLine();
                while(j != "s" && j != "n")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Tente digitar [s/n].");
                    Console.ResetColor();
                    Console.Write("Digite:");
                    j = Console.ReadLine();
                }
                Console.WriteLine();
                if(j == "s")
                {
                    CadastrarArtefato( s, r);
                    foreach( Artefato a in Sistema.ArtefatoListar() )
                    {
                        if( a.GetTipo() == s )
                        {
                            Console.WriteLine(a);
                            Console.WriteLine();
                        }
                    }
                    Console.Write("Digite o ID do artefato: ");
                    Id = int.Parse(Console.ReadLine());
                    switch(s)
                    {
                        case "FLOR": p.SetIdArtefato1(Id); break;
                        case "PENA": p.SetIdArtefato2(Id); break;
                        case "RELOGIO": p.SetIdArtefato3(Id); break;
                        case "CÁLICE": p.SetIdArtefato4(Id); break;
                        case "TIARA": p.SetIdArtefato5(Id); break;
                    }
                }
                else
                {
                    MenuSubPersonagemArtefato(p, s);
                }
            }
            else
            {
                Console.Write("Digite o ID do artefato: ");
                Id = int.Parse(Console.ReadLine());
                switch(s)
                {
                    case "FLOR": p.SetIdArtefato1(Id); break;
                    case "PENA": p.SetIdArtefato2(Id); break;
                    case "RELOGIO": p.SetIdArtefato3(Id); break;
                    case "CÁLICE": p.SetIdArtefato4(Id); break;
                    case "TIARA": p.SetIdArtefato5(Id); break;
                }
                
            }
            
        }
        static public Artefato BuscarArtefato(int Id)
        {
            foreach(Artefato a in Sistema.ArtefatoListar())
            {
                if(Id == a.GetId())
                {
                    return a;
                }
            }
            Artefato Art = new Artefato("None");
            return Art;
        }
    }
}