namespace Peoples.Domain;

public class GtProfile : BaseGtProfile
{
    public Guid AppUserId { get; set; }

    public string NickName { get; set; }

    public Guid LocationId { get; set; }

    public string EMail { get; set; }

    public string? About { get; set; }

    public string? Age { get; set; }

    public string? ImageUrl { get; set; }



    //For communicate with roles
    //[ForeignKey("ApplicationUserId")]
    //public ApplicationUser ApplicationUser { get; set; }
    //public string ApplicationUserId { get; set; }
}
