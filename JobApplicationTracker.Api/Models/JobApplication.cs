namespace JobApplicationTracker.Api.Models;

public class JobApplication
{
    public int Id { get; set; }

    public string JobTitle { get; set; } = string.Empty;

    public string Company { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public string Status { get; set; } = "Applied";

    public DateTime DateApplied { get; set; }

    public DateTime? InterviewDate { get; set; }

    public decimal? Salary { get; set; }

    public string? Notes { get; set; }


    // Relationship with User
    public string UserId { get; set; } = string.Empty;

    public ApplicationUser User { get; set; } = null!;
}