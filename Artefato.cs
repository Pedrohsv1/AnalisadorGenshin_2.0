using System;
namespace AnalyzerGenshin
{
    public class Artefato : IComparable<Artefato>
    {
        private int id;
        private int idPersonagem;
        private string nome;
        private string tipo;
        private string mainStatus;
        private string status1;
        private string status2;
        private string status3;
        private string status4;
        private double valorMainStatus;
        private double valorStatus1;
        private double valorStatus2;
        private double valorStatus3;
        private double valorStatus4;

        public Artefato(int id, string nome, string tipo, string mainStatus, string status1, string status2, string status3, string status4, double valorMainStatus, double valorStatus1, double valorStatus2, double valorStatus3, double valorStatus4)
        {
            this.id = id;
            this.nome = nome;
            this.tipo = tipo;
            this.mainStatus = mainStatus;
            this.status1 = status1;
            this.status2 = status2;
            this.status3 = status3;
            this.status4 = status4;
            this.valorMainStatus = valorMainStatus;
            this.valorStatus1 = valorStatus1;
            this.valorStatus2 = valorStatus2;
            this.valorStatus3 = valorStatus3;
            this.valorStatus4 = valorStatus4;
        }
        public override string ToString()
        {
            return $" {tipo} | {nome}\n {mainStatus} - {valorMainStatus}\n {status1} - {valorStatus1}\n {status2} - {valorStatus2}\n {status3} - {valorStatus3}\n {status4} - {valorStatus4}";
        }
        public string GetNome()
        {
            return nome;
        }
        public int CompareTo(Artefato Obj)
        {
            return GetNome().CompareTo(Obj.GetNome());
        }
    }
}