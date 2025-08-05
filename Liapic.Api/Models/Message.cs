using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Liapic.Api.Models;

/// <summary>
/// Représente un message envoyée par un utilisateur.
/// Contient l'auteur du message, le texte du message, 
/// la date d'envoi et une vérification de lecture.
/// </summary>
[Table("Messages")]
public class Message
{
    [Key]
    public int Id { get; set; }

    [Required]
    public required int ConversationId { get; set; }

    [ForeignKey(nameof(ConversationId))]
    public required Conversation Conversation { get; set; }
    [Required]
    public required int AuteurId { get; set; }

    [ForeignKey(nameof(AuteurId))]
    public required Utilisateur Auteur { get; set; }

    [Required]
    public required string MessageTexte { get; set; }

    public bool Lu { get; set; } = false;

    public DateTime DateEnvoi { get; set; } = DateTime.UtcNow;
}