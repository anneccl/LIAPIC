using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Liapic.Api.Models;

/// <summary>
/// Représente un abonnement à un utilisateur.
/// Contient un utilisateur qui est abonné à un autre utilisateur.
/// conversation.
/// </summary>
[Table("Abonnements")]
public class Abonnement
{
    [Key]
    public int Id { get; set; }
    [Required]
    public required int SuiviId { get; set; }

    [ForeignKey(nameof(SuiviId))]
    public required Utilisateur Suivi { get; set; }

    [Required]
    public required int SuiveurId { get; set; }

    [ForeignKey(nameof(SuiveurId))]
    public required Utilisateur Suiveur { get; set; }

    public DateTime DateAbonnement { get; set; } = DateTime.UtcNow;

}
