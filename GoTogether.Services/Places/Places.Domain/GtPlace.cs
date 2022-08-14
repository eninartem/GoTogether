namespace Places.Domain;

public class GtPlace
{
    public Guid Id { get; set; }
    public string Address { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public GtLocation Location { get; set; }
    public Guid LocationId { get; set; }
}
