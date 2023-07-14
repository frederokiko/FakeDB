using System;
using TFNetSecurity.Models;

namespace TFNetSecurity.Entyities
{
    public static class FakeDB
    {
        static List<User> Users = new List<User>()
        {
            new User(1, "Renaux", "Frédéric", " frederokiko@hotmail.com ", DateTime.Now),
            new User(2, "Lessire", "Pol", " lespol@hic.fr ", DateTime.Now),
            new User(3, "Dubois", "Sophie", " sophiedubois@gmail.com ", DateTime.Now),
            new User(4, "Martin", "Thomas", " thomas.martin@example.com ", DateTime.Now),
            new User(5, "Lefebvre", "Laura", " laura.lefebvre@gmail.com ", DateTime.Now),
            new User(6, "Dupont", "Alexandre", " alex.dupont@exemple.com ",DateTime.Now),
            new User(7, "Leclerc", "Julie", " julie.leclerc@outlook.com ", DateTime.Now),
            new User(8, "Garcia", "Pierre", " p.garcia@example.com ", DateTime.Now),
            new User(9, "Moreau", "Charlotte", " charlotte.moreau@gmail.com ", DateTime.Now),
            new User(10, "André", "David", " david.andre@outlook.com ", DateTime.Now),
            new User(11, "Simon", "Marie", " marie.simon@example.com ", DateTime.Now),
            new User(12, "Leroy", "Mathieu", " leroy.mathieu@gmail.com ", DateTime.Now),
            new User(13, "Girard", "Catherine", " c.girard@example.com ", DateTime.Now),
            new User(14, "Bertrand", "Lucie", " lucie.bertrand@outlook.com ", DateTime.Now),
            new User(15, "Roy", "Antoine", " antoine.roy@example.com ", DateTime.Now),
            new User(16, "Morin", "Isabelle", " isabelle.morin@gmail.com ", DateTime.Now),
            new User(17, "Lefevre", "Nicolas", " nicolas.lefevre@example.com ",DateTime.Now),
            new User(18, "Gagnon", "Camille", " camille.gagnon@outlook.com ", DateTime.Now),
            new User(19, "Poirier", "Julien", " julien.poirier@example.com ", DateTime.Now),
            new User(20, "Laroche", "Sophie", " sophie.laroche@gmail.com ", DateTime.Now),
            new User(21,"Renaux","frederic","frederokiko@hotmail.com",DateTime.Now),
            new User(22,"Lessire","Pol","lespol@hic.fr",DateTime.Now)

        };
        public static List<User> GetAll()
        {
            return Users;
        }
        public static User GetById(int id)
        {
            return Users.FirstOrDefault(a => a.Id == id);
        }
        public static void Ajouter(User f)
        {
            f.Id = Users.Count + 1;
           Users.Add(f);
            
        }
        public static void Delete(int id)
        {
            User toDel = GetById(id);
            Users.Remove(toDel);
        }

        public static void UpdateEntite(User entite)
        {
            User entiteToUpdate = Users.FirstOrDefault(e => e.Id == entite.Id);
            if (entiteToUpdate != null)
            {
                // Mettre à jour les propriétés de l'entité
                entiteToUpdate.Nom = entite.Nom;
                entiteToUpdate.Prenom = entite.Prenom;
                entiteToUpdate.Email = entite.Email;
                entiteToUpdate.Birthdate = entite.Birthdate;

                // Autres propriétés à mettre à jour
            }
        }
    }

}
