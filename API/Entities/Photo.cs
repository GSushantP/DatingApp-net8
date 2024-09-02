using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

[Table("Photos")]
public class Photo
{
    public int Id { get; set; }
    public required string Url { get; set; }
    public bool IsMain { get; set; }
    public string? PiblicId { get; set; }

    //Navigation properties

    public int AppUsersID { get; set; }
    public AppUsers AppUsers { get; set; } = null!;
}