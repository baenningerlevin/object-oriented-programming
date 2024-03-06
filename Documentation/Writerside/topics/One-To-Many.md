# One-To-Many

Mit EF Core können wir auch One-To-Many Relationen kreieren. Bei One-To-Many Relationen gibt es einmal die **Required One-To-Many** und die **Optional
One-To-Many** Relation.

## Required One-To-Many

````C#
public class Blog
{
    public int Id { get; set; }
    public ICollection<Post> Posts { get; } = new List<Post>();
}

public class Post
{
    public int Id { get; set; }
    public int BlogId { get; set; }
    
    [ForeignKey(nameof(BlogId))]
    public Blog? Blog { get; set; } = null!;
}
````

Eine One-To-Many Relation besteht aus:

- **Primärschlüssel** - Der Primärschlüssel repräsentiert die **One**-Seite der Relation, hier `Blog.Id`
- **Fremdschlüssel** - Der Fremdschlüssel repräsentiert die **Many**-Seite der Relation, hier `Post.BlogId`
- **Collection Navigation** - Referenziert die abhängigen Entities, hier `Blog.Posts`
- **Reference Navigation** - Referenziert das Parent-Entity, hier `Post.Blog`

Da das Attribut `Post.BlogId` nicht nullable ist, ist die Relation **required**.

## Optional One-To-Many

`````C#
public class Blog
{
    public int Id { get; set; }
    public ICollection<Post> Posts { get; } = new List<Post>();
}

public class Post
{
    public int Id { get; set; }
    public int? BlogId { get; set; }
    public Blog? Blog { get; set; }
}
`````

Die Optional One-To-Many Relation ist exakt gleich aufgebaut, wie die obere Relation, ausser, dass `Post.BlogId` und `Post.Blog` nun nullable und
somit **optional** sind.