using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Liapic.Api.Models;
/// <summary>
/// Représente un commentaire sous une publication.
/// Contient  l'utilisateur qui a commenté une publication et la publication aimée.
/// </summary>
[Table("Commentaires")]
public class Commentaire
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int UtilisateurId { get; set; }

    [ForeignKey(nameof(UtilisateurId))]
    public required Utilisateur Utilisateur { get; set; }

    [Required]
    public required string Texte { get; set; }
    public DateTime DateCommentaire { get; set; } = DateTime.UtcNow;
}