namespace NetCoreCv.Core.Models;
public class Project : IModel
{
    public int Id => ProjectId;

    public int ProjectId { get; set; }

    public string Title { get; set; } = "";

    public string Description { get; set; } = "";

    public Project() {

    }
}
