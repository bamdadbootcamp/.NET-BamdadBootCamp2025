using Trello.WebApi.Domain.Entities.Core;

namespace Trello.WebApi.Domain.Entities;

public class Issue : BaseEntityType
{
    private Issue()
    {
    }

    public string Title { get; private set; }
    public string Description { get; private set; }
    public List List { get; private set; }
    public long ListId { get; private set; }

    public static Issue Create(string title, string description, long listId)
    {
        return new Issue()
        {
            ListId = listId,
            Title = title,
            Description = description
        };
    }

    public void Update(
        string? title = null,
        string? description = null,
        long? listId = null
    )
    {
        if (!string.IsNullOrWhiteSpace(title)
            && !string.Equals(Title, title, StringComparison.Ordinal))
        {
            Title = title;
        }

        if (!string.IsNullOrWhiteSpace(description)
            && !string.Equals(Description, description, StringComparison.Ordinal))
        {
            Description = description;
        }

        if (listId.HasValue
            && ListId != listId.Value)
        {
            ListId = listId.Value;
        }
    }
}