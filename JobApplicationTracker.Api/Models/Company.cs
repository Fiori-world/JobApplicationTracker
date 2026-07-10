namespace JobApplicationTracker.Api.Models;

public class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public string? Website { get; set; }


    public ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();
}