using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Liapic.Api.Models;

/// <summary>
/// Représente un like (un "j'aime") d'une publication.
/// Contient  l'utilisateur qui a aimé une publication et la publication aimée.
/// </summary>
[Table("Aimes")]
public class Aime
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public int UtilisateurId { get; set; }

    [ForeignKey(nameof(UtilisateurId))]
    public required Utilisateur Utilisateur { get; set; }

    [Required]
    public int PublicationId { get; set; }

    [ForeignKey(nameof(PublicationId))]
    public required Publication Publication { get; set; }

    public DateTime DateAime { get; set; } = DateTime.UtcNow;
}