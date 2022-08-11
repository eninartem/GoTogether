namespace Peoples.Domain;

public abstract class BaseGtProfile
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime LastModifiedDate { get; set; }
}
