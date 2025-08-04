using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table]
public class Utilisateur
{
    [Key]
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string NomUtilisateur { get; set; }
    public string Email { get; set; }
    [Password]
    public string MotDePasse { get; set; }
    public string Biographie { get; set; }
    public string PhotoProfilUrl { get; set; }
    public DateTime DateInscription { get; set; }
}