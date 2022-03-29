namespace AnalyzerGenshin
{
    public class Usuario
    {
        private int id;
        private string email;
        private string senha;

        public Usuario()
        {
        }
        public Usuario(string email, string senha, int id)
        {
            this.email = email;
            this.senha = senha;
            this.id = id;
        }
        public string Email
        {
            get{return email;}
            set{email=value;}
        }
        public string Senha
        {
            get{return senha;}
            set{senha=value;}
        }
        public int Id
        {
            get{return id;}
            set{id=value;}
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public void SetSenha(string senha)
        {
            this.senha = senha;
        }
        public string GetEmail()
        {
            return email;
        }
        public string GetSenha()
        {
            return senha;
        }
        public int GetId()
        {
            return id;
        }
        public override string ToString()
        {
            return $"ID: {id}\nEmail: {email} - Senha: {senha}\n";
        }
    }
}