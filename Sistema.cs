using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace AnalyzerGenshin
{
    public class Sistema
    {
        private static List<Usuario> usuarios = new List<Usuario>();
        private static List<Artefato> artefatos = new List<Artefato>();
        private static List<Personagem> personagens= new List<Personagem>();
        private static List<Talento> talentos = new List<Talento>();

        public static void LerArquivoUsuario()
        {
            Arquivos<List<Usuario>> ArquivoUsuario = new Arquivos<List<Usuario>>();
            usuarios = ArquivoUsuario.Ler("Xmls/Users.xml");
        }
        public static void EscreverArquivoUsuario()
        {
            Arquivos<List<Usuario>> ArquivoUsuario = new Arquivos<List<Usuario>>();
            ArquivoUsuario.Escrever("Xmls/Users.xml", usuarios);
        }
        public static void LerArquivo(int id)
        {
            Arquivos<List<Artefato>> ArquivoArtefato = new Arquivos<List<Artefato>>();
            artefatos = ArquivoArtefato.Ler($"Xmls/Artefato{id}.xml");

            Arquivos<List<Personagem>> ArquivoPersonagem = new Arquivos<List<Personagem>>();
            personagens = ArquivoPersonagem.Ler($"Xmls/Personagem{id}.xml");

            Arquivos<List<Talento>> ArquivoTalento = new Arquivos<List<Talento>>();
            talentos = ArquivoTalento.Ler($"Xmls/Talento{id}.xml");
        }
        public static void EscreverArquivo(int id)
        {
            Arquivos<List<Artefato>> ArquivoArtefato = new Arquivos<List<Artefato>>();
            ArquivoArtefato.Escrever($"Xmls/Artefato{id}.xml", artefatos);

            Arquivos<List<Personagem>> ArquivoPersonagem = new Arquivos<List<Personagem>>();
            ArquivoPersonagem.Escrever($"Xmls/Personagem{id}.xml", personagens);

            Arquivos<List<Talento>> ArquivoTalento = new Arquivos<List<Talento>>();
            ArquivoTalento.Escrever($"Xmls/Talento{id}.xml", talentos);
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
        public static void UsuarioInserir(Usuario obj)
        {
            usuarios.Add(obj);
        }
        public static void UsuarioExcluir(Usuario obj)
        {
            usuarios.Remove(obj);
        }
        public static List<Usuario> UsuarioListar()
        {
            return usuarios;
        }
    }
}