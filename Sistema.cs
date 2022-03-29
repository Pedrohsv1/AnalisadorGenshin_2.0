using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AnalyzerGenshin
{
    public class Sistema
    {
        private static List<Artefato> artefatos = new List<Artefato>();
        private static List<Personagem> personagens= new List<Personagem>();
        private static List<Talento> talentos = new List<Talento>();

        public static void AbrirArquivo()
        {
            Arquivos<List<Artefato>> ArquivoArtefato = new Arquivos<List<Artefato>>();
            artefatos = ArquivoArtefato.Abrir("Artefato.xml");

            Arquivos<List<Personagem>> ArquivoPersonagem = new Arquivos<List<Personagem>>();
            personagens = ArquivoPersonagem.Abrir("Artefato.xml");

            Arquivos<List<Artefato>> ArquivoTalento = new Arquivos<List<Artefato>>();
            artefatos = ArquivoTalento.Abrir("Artefato.xml");
        }
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
        public static List<Artefato> ArtefatoListar()
        {
            List<Artefato> a = artefatos;
            a.Sort();
            return a;
        }
        public static void TalentoInserir(Talento obj)
        {
            talentos.Add(obj);
        }
        public static void TalentoExcluir(Talento obj)
        {
            talentos.Remove(obj);
        }
        public static List<Talento> TalentoListar()
        {
            return talentos;
        }
    }
}