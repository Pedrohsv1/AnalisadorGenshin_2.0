using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;


namespace AnalyzerGenshin
{
    class Arquivos<T>
    {
        public T Ler(string nome)
        {
            //T vai receber XML
            XmlSerializer x = new XmlSerializer(typeof(T));
            StreamReader y = new StreamReader(nome, Encoding.Default);
            
            T b = (T) x.Deserialize(y);
            y.Close();
            return b;
        }
        public void Escrever(string nome, T obj)
        {
            //XMl vai receber em formato T
            XmlSerializer x = new XmlSerializer(typeof(T));
            StreamWriter y = new StreamWriter(nome, false, Encoding.Default);
            
            x.Serialize(y, obj);
            y.Close();
        }
    }
}