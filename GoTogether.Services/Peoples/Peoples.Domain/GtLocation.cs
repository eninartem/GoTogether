namespace Peoples.Domain;

public class GtLocation
{
    public Guid Id { get; set; }
    public string Country { get; set; }
    public string City { get; set; }

    public List<GtProfile> GtProfiles { get; set; }
}
