using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary.Models;

public class Art
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public int MyArtId { get; set; }
    [Required]
    [MaxLength(50)]
    public string Title { get; set; } = string.Empty;
    [Required]
    [MaxLength(50)]
    public string Author { get; set; } = string.Empty;
    public string ArtImageName { get; set; } = "helloWorld.JPG";
    public string? Description { get; set; }
    public DateTime Create { get; set; } = DateTime.Now;

}
