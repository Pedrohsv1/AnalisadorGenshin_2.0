namespace AnalyzerGenshin
{
    public class Talento
    {
        private int id;
        private int idPersonagem;
        private string nome;
        private int level;

        public Talento(int id, int idPersonagem, string nome, int level)
        {
            this.id = id;
            this.idPersonagem = idPersonagem;
            this.nome = nome;
            this.level = level;
        }
        public override string ToString()
        {
            return $"\n Id - {id}\n Level : {level} | Nome : {nome}\n";
        }
        public int GetId()
        {
            return id;
        }
        public string GetNome()
        {
            return nome;
        }
        public int GetLevel()
        {
            return level;
        }
    }
}