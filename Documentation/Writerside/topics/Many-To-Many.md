# Many-To-Many

Im Gegensatz zu 1:N- und 1:1-Relationen können M:N-Relationen nicht einfach mithilfe eines Fremdschlüssels dargestellt werden. Stattdessen muss eine
dritte Tabelle erstellt werden, eine sogenannte **Jointabelle**.

````C#
public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public Author Author { get; set; }
    public ICollection<BookCategory> BookCategories { get; set; }
}  

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public ICollection<BookCategory> BookCategories { get; set; }
}  

public class BookCategory
{
    public int BookId { get; set; }
    [ForeignKey(nameof(BookId))]
    public Book? Book { get; set; }
    
    public int CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public Category? Category { get; set; }
}
````

Hier ist unsere Jointabelle `BookCategory`, wo wir die Tabelle `Book` und die Tabelle `Category` referenzieren. Um nun die Relation korrekt zu mappen,
müssen wir diesen noch mit der **Fluent API** konfigurieren:

`````C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<BookCategory>()
        .HasKey(bc => new { bc.BookId, bc.CategoryId });  
        
    modelBuilder.Entity<BookCategory>()
        .HasOne(bc => bc.Book)
        .WithMany(b => b.BookCategories)
        .HasForeignKey(bc => bc.BookId);  
        
    modelBuilder.Entity<BookCategory>()
        .HasOne(bc => bc.Category)
        .WithMany(c => c.BookCategories)
        .HasForeignKey(bc => bc.CategoryId);
        
    base.OnModelCreating(modelBuilder);
}
`````