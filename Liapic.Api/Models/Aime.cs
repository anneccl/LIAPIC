/// <summary>
/// Représente un like (un "j'aime") d'une publication.
/// Contient  l'utilisateur qui a aimé une publication et la publication aimée.
/// </summary>
[Table("Aimes")]
public class Aime
{
    [Key]
    public int UtilisateurId {get;set;}

    [ForeignKey(nameof(UtilisateurId))]
    public Utilisateur Utilisateur { get; set; }

    [Key]
    public int PublicationId { get; set; }

    [ForeignKey(nameof(PublicationId))]
    public Publication Publication { get; set; }

    public DateTime DateAime { get; set; } = DateTime.UtcNow;
}