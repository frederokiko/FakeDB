namespace TFNetSecurity.Models
{
    public  class User
    {
       

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }


        public User(int id, string nom, string prenom,string email,DateTime birthdate)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Birthdate = birthdate;
        }
        public User()
        {

        }
    }

}
