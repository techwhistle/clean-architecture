namespace BlogApi.Application.DTOs;

public class TagDto
{
    /// <summary>
    /// The unique identifier for the tag.
    /// </summary>
    public Guid TagId { get; set; }

    /// <summary>
    /// The name of the tag.
    /// </summary>
    public string Name { get; set; } = string.Empty;
}