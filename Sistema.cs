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
        public static List<Personagem> PersonagemListar()
        {
            List<Personagem> p = personagens;
            p.Sort();
            return p;
        }
        public static void ArtefatoInserir(Artefato obj)
        {
            artefatos.Add(obj);
        }
        public static void ArtefatoExcluir(Artefato obj)
        {
            artefatos.Remove(obj);
        }
        public static List<Artefato> ArtefatoListar(Artefato obj)
        {
            return artefatos;
        }
    }
}