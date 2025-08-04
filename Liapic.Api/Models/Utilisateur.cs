/// <summary> 
/// Représente un utilisateur inscrit sur la plateforme Liapic.
/// Contient ses informations de profil, de connexion et de description.
/// </summary>
[Table("Utilisateurs")]
public class Utilisateur
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Nom { get; set; }

    [Required]
    [MaxLength(50)]
    public string Prenom { get; set; }

    [Required]
    [MaxLength(30)]
    public string NomUtilisateur { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string MotDePasse { get; set; }

    [MaxLength(280)]
    public string Biographie { get; set; }

    [Url]
    public string? PhotoProfilUrl { get; set; }

    public DateTime DateInscription { get; set; } = DateTime.UtcNow;
}