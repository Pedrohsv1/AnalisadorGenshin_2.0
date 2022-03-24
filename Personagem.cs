using System;

namespace AnalyzerGenshin
{
    public class Personagem : IComparable<Personagem>
    {
        private int id;
        private int level;
        private string nome;
        private string tipo;
        private int idArtefato_1;
        private int idArtefato_2;
        private int idArtefato_3;
        private int idArtefato_4;
        public string GetNome()
        {
            return nome;
        }
        public int CompareTo(Personagem Obj)
        {
            return GetNome().CompareTo(Obj.GetNome());
        }
    }
}