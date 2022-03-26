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
        private int idArtefato5;

        public Personagem(int id, int level, string nome, string tipo, int idArtefato1, int idArtefato2, int idArtefato3, int idArtefato4, int idArtefato5)
        {
            this.id = id;
            this.level = level;
            this.nome = nome;
            this.tipo = tipo;
            this.idArtefato1 = idArtefato1;
            this.idArtefato2 = idArtefato2;
            this.idArtefato3 = idArtefato3;
            this.idArtefato4 = idArtefato4;
            this.idArtefato4 = idArtefato5;
        }

        public string GetNome()
        {
            return nome;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public int GetId()
        {
            return id;
        }
        public int GetLevel()
        {
            return level;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetLevel(int level)
        {
            this.level = level;
        }
        public int CompareTo(Personagem Obj)
        {
            return GetNome().CompareTo(Obj.GetNome());
        }
        public override string ToString()
        {
            return $"ID: {id}\nNome: {nome} - Tipo: {tipo}\nLevel: {level}\n";
        }
    }
}