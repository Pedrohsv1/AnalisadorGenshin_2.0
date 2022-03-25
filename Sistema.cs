using System; 
using System.Collections.Generic;

namespace AnalyzerGenshin
{
    public class Sistema
    {
        private static List<Artefato> artefatos = new List<Artefato>();
        private static List<Personagem> personagens= new List<Personagem>();
        private static List<Talento> talentos = new List<Talento>();

        public static void PersonagemInserir(Personagem obj)
        {
            personagens.Add(obj);
        }
        public static void PersonagemExcluir(Personagem obj)
        {
            personagens.Remove(obj);
        }
        public static List<Personagem> PersonagemListar(Personagem obj)
        {
            return personagens;
        }
    }
}