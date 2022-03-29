using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;


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
        public Personagem(){}
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
            this.idArtefato5 = idArtefato5;
        }

        public int Id
        {
            get{return id;}
            set{id=value;}
        }
        public string Nome
        {
            get{return nome;}
            set{nome=value;}
        }
        public int Level
        {
            get{return level;}
            set{level=value;}
        }
        public string Tipo
        {
            get{return tipo;}
            set{tipo=value;}
        }
        public int IdArtefato1
        {
            get{return idArtefato1;}
            set{idArtefato1=value;}
        }
        public int IdArtefato2
        {
            get{return idArtefato2;}
            set{idArtefato2=value;}
        }
        public int IdArtefato3
        {
            get{return idArtefato3;}
            set{idArtefato3=value;}
        }
        public int IdArtefato4
        {
            get{return idArtefato4;}
            set{idArtefato4=value;}
        }
        public int IdArtefato5
        {
            get{return idArtefato5;}
            set{idArtefato5=value;}
        }
        public string GetNome()
        {
            return nome;
        }
        public int GetId()
        {
            return id;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public int GetIdArtefato1()
        {
            return idArtefato1;
        }
        public int GetIdArtefato2()
        {
            return idArtefato2;
        }
        public int GetIdArtefato3()
        {
            return idArtefato3;
        }
        public int GetIdArtefato4()
        {
            return idArtefato4;
        }
        public int GetIdArtefato5()
        {
            return idArtefato5;
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
        public void SetIdArtefato1(int ID)
        {
            this.idArtefato1 = ID;
        }
        public void SetIdArtefato2(int ID)
        {
            this.idArtefato2 = ID;
        }
        public void SetIdArtefato3(int ID)
        {
            this.idArtefato3 = ID;
        }
        public void SetIdArtefato4(int ID)
        {
            this.idArtefato4 = ID;
        }
        public void SetIdArtefato5(int ID)
        {
            this.idArtefato5 = ID;
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