using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Liapic.Api.Models;
/// <summary>
/// Représente un commentaire sous une publication.
/// Contient un utilisateur ayant commenté une publication et son 
/// commentaire(le message laissé sous la publication)
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
    public int PublicationId { get; set; }

    [ForeignKey(nameof(PublicationId))]
    public required Publication Publication { get; set; }

    [Required]
    [MaxLength(500)]
    public required string Texte { get; set; }
    
    public DateTime DateCommentaire { get; set; } = DateTime.UtcNow;
}