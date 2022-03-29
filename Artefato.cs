using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;


namespace AnalyzerGenshin
{
    public class Artefato : IComparable<Artefato>
    {
        private int id;
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


        public Artefato(){}
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
        public Artefato(string tipo)
        {
            this.tipo = tipo;
        }
        public override string ToString()
        {
            return $"\n Id - {id}\n\n {tipo} | {nome}\n\n {mainStatus} - {valorMainStatus}\n\n {status1} - {valorStatus1}\n {status2} - {valorStatus2}\n {status3} - {valorStatus3}\n {status4} - {valorStatus4}";
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
        public string Tipo
        {
            get{return tipo;}
            set{tipo=value;}
        }
        public string MainStatus
        {
            get{return mainStatus;}
            set{mainStatus=value;}
        }
        public string Status1
        {
            get{return status1;}
            set{status1=value;}
        }
        public string Status2
        {
            get{return status2;}
            set{status2=value;}
        }
        public string Status3
        {
            get{return status3;}
            set{status3=value;}
        }
        public string Status4
        {
            get{return status4;}
            set{status4=value;}
        }
        public double ValorMainStatus
        {
            get{return valorMainStatus;}
            set{valorMainStatus=value;}
        }
        public double ValorStatus1
        {
            get{return valorStatus1;}
            set{valorStatus1=value;}
        }
        public double ValorStatus2
        {
            get{return valorStatus2;}
            set{valorStatus2=value;}
        }
        public double ValorStatus3
        {
            get{return valorStatus3;}
            set{valorStatus3=value;}
        }
        public double ValorStatus4
        {
            get{return valorStatus4;}
            set{valorStatus4=value;}
        }
        public string GetTipo()
        {
            return tipo;
        }
        public int GetId()
        {
            return id;
        }
        public string GetNome()
        {
            return nome;
        }
        public int CompareTo(Artefato Obj)
        {
            return GetNome().CompareTo(Obj.GetNome());
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetTipo(string nome)
        {
            this.nome = nome;
        }
        public void SetMainStatus(string mainStatus)
        {
            this.mainStatus = mainStatus;
        }
        public void SetStatus1(string status1)
        {
            this.status1 = status1;
        }
        public void SetStatus2(string status2)
        {
            this.status2 = status2;
        }
        public void SetStatus3(string status3)
        {
            this.status3 = status3;
        }
        public void SetStatus4(string status4)
        {
            this.status4 = status4;
        }
        public void SetValorMainStatus(double valorMainStatus)
        {
            this.valorMainStatus = valorMainStatus;
        }
        public void SetValorStatus1(double valorStatus1)
        {
            this.valorStatus1 = valorStatus1;
        }
        public void SetValorStatus2(double valorStatus2)
        {
            this.valorStatus2 = valorStatus2;
        }
        public void SetValorStatus3(double valorStatus3)
        {
            this.valorStatus3 = valorStatus3;
        }
        public void SetValorStatus4(double valorStatus4)
        {
            this.valorStatus4 = valorStatus4;
        }

    }
}