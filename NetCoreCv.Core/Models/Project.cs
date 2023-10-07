namespace NetCoreCv.Core.Models;
public class Project
{
    public int ProjectId { get; set; }

    public int? AddressId { get; set; }

    public string Title { get; set; } = "";

    public string Description { get; set; } = "";

    public Address? Address { get; set; }

    public Project()
    {

    }
}
