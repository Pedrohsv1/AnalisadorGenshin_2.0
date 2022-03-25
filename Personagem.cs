using System;

namespace AnalyzerGenshin
{
    public class Personagem : IComparable<Personagem>
    {
        private int id;
        private int level;
        private string nome;
        private string tipo;
        private int idArtefato1;
        private int idArtefato2;
        private int idArtefato3;
        private int idArtefato4;

        public Personagem(int id, int level, string nome, string tipo, int idArtefato1, int idArtefato2, int idArtefato3, int idArtefato4)
        {
            this.id = id;
            this.level = level;
            this.nome = nome;
            this.tipo = tipo;
            this.idArtefato1 = idArtefato1;
            this.idArtefato2 = idArtefato2;
            this.idArtefato3 = idArtefato3;
            this.idArtefato4 = idArtefato4;
        }

        public string GetNome()
        {
            return nome;
        }
        public int CompareTo(Personagem Obj)
        {
            return GetNome().CompareTo(Obj.GetNome());
        }
        public override string ToString()
        {
            return $"{nome} - {tipo}\nLevel: {level}";
        }
    }
}