# Controller

Der Controller ist der Vermittler zwischen Model und View, verarbeitet Benutzereingaben und steuert Datenfluss zu Model und View

## Controller erstellen

Den Controller erstellen wir unter dem Ordner <ui-path>Controller</ui-path>. Wenn wir einen Controller erstellen wollen, gibt es verschiedene
Vorlagen. In diesem Fall wählen wir die Vorlage <ui-path>MVC-Controller mit Ansichten unter Verwendung Entity Framework</ui-path> aus.

> Diese Vorlage wird in der Praxis so gut wie nie verwendet, ist jedoch praktisch, um den grundlegenden Aufbau einer Applikation zu sehen

In den Feldern müssen wir einerseits, das **Modell** angeben, aus welchem wir den Controller erstellen müssen und die Klasse mit welcher **die
Kommunikation zwischen Applikation und Server** abläuft. Zuletzt müssen wir den **Namen unseres Controllers** definieren.

> Die Konvention für Controller-Namen ist, dass es immer die **Mehrzahl des Modelklassen-Namens** sein soll. Zudem muss der Name des Controllers auf *
*Controller** enden

Nach der Erstellung sehen wir, dass .NET einen Standard-Controller mit den Views `Index`, `Edit`, `Detail` und `Create` und `Delete` erstellt hat.

## Controller aufrufen

Um den Controller in der Applikation zu öffnen, müssen wir in der URL `/NameOfController` anfügen. Nun sehen wir die `Index`-Seite, die uns .NET
erstellt hat.

Wenn wir ein weiteres `/` anhängen können wir noch die Methode bestimmen, die aufgerufen werden soll, bspw. `/Apprentices/Create`.

### Controller zur Navigation hinzufügen

Damit wir nicht immer die URL ändern müssen um die `Index`-View des Controllers aufrufen müssen, können wir den Link zur Navigation hinzufügen.

Dafür gehen wir zum File `Views/Shared/_Layout.cshtml`. Diese Datei ist eine spezielle, denn sie wird auf jeder Seite gerendert. Hier können wir nun
in der Liste folgendes einfügen:

````Razor
<li class="nav-item">
    <a class="nav-link text-dark" asp-area="" asp-controller="Apprentices" asp-action="Index">Lernende</a>
</li>
````

## Funktionsweise des Controllers

### Dependency Injection

Ganz oben im Controller definieren wir immer die Datenbank, beispielsweise so:

````C#
private readonly ApplicationDbContext _context;

public ApprenticesController(ApplicationDbContext context)
{
    _context = context;
}
````

### Views im Controller

Im Controller werden Views in einer Methode zurückgegeben. Der Name der Methode ist eine Aktion des Controllers, die wir auch in der URL aufrufen
können:

````C#
public IActionResult Create()
{
    return View();
}
````

### Forms

Um Daten von einem Formular in der Datenbank zu speichern, können wir folgendes machen:

````C#
[HttpPost]
public IActionResult Create(Category obj)
{
    // Server-Side Validations
    if (obj.Name == obj.DisplayOrder)
    {
        ModelState.AddModelError("The display order can't exactly match the name");
    }
    
    // Check if validations where successful 
    if (ModelState.IsValid)
    {
        _db.Categories.Add(obj);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    
    return View();
}
````

In diesem Beispiel validieren wir zuerst die Eingabe auf dem Server, alle anderen Validierungen wurden bereits mit JQuery auf der Client-Side gemacht.

Danach wird überprüft, ob alle Validierungen erfolgreich waren. Wenn ja, wird das Objekt zur Datenbank hinzugefügt, wenn nein, wird die `Create`-View
neu geladen.

### Umgang mit IDs

IDs werden vor allem für das Löschen und Editieren von Datensätzen gebraucht. Dafür benutzen wir in der View den Tag-Helper `asp-route-...`. In
unserem Fall nennen wir den Parameter `categoryId`, also `asp-route-categoryId` und geben dem Attribut den Wert von `@obj.categoryId`.

Diese ID können wir nun im Controller ansprechen:

````C#
public IActionResult Edit(int? id) 
{
    // Check if id is valid
    if (id == null || id == 0) 
    {
        return NotFound();
    }
    
    // Search for data
    Category categoryFromDb = _db.Categories.Find(id);
    if (categoryFromDb == null)
    {
        return NotFound
    }
    
    return View(categoryFromDb)
}
````