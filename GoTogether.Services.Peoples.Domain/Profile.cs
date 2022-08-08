namespace GoTogether.Services.Peoples.Domain;

public class Profile
{
    public Guid Id { get; set; }

    public string NickName { get; set; }

    public string Age { get; set; }

    public Guid LocationId { get; set; }

    public string About { get; set; }
}
