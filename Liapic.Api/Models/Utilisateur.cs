using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Liapic.Api.Models;

/// <summary> 
/// Représente un utilisateur inscrit sur la plateforme Liapic.
/// Contient ses informations de profil, de connexion et une biographie.
/// </summary>
[Table("Utilisateurs")]
public class Utilisateur
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Nom { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Prenom { get; set; }

    [Required]
    [MaxLength(30)]
    public required string NomUtilisateur { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public required string MotDePasse { get; set; }

    [MaxLength(280)]
    public string? Biographie { get; set; }

    [Url]
    public string? PhotoProfilUrl { get; set; }

    public DateTime DateInscription { get; set; } = DateTime.UtcNow;
}