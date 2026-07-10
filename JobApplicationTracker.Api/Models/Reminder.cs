namespace JobApplicationTracker.Api.Models;

public class Reminder
{
    public int Id { get; set; }

    public DateTime ReminderDate { get; set; }

    public string Message { get; set; } = string.Empty;

    public bool Completed { get; set; }


    // Relationship
    public int JobApplicationId { get; set; }

    public JobApplication JobApplication { get; set; } = null!;
}