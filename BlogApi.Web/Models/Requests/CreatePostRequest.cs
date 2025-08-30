namespace BlogApi.Web.Models.Requests;

public record CreatePostRequest(string Title, string Content, Guid AuthorId);
