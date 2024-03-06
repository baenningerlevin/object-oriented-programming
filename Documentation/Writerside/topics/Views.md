# Views

Views rendern die Benutzeroberfläche, präsentieren Daten dem Benutzer und sind abhängig vom Modell.

## Views erstellen

In ASP.NET Core haben die Views die Dateiendung `.cshtml`. Das ist eine Kombination aus C# und HTML. Dazu wird bei jedem ASP.NET Core Projekt
automatisch Bootstrap und JQuery hinzugefügt, um die Frontend-Entwicklung leichter zu gestalten.

Views müssen immer in einem Ordner sein der gleich heisst, wie der Controller. Darin kann man dann Views erstellen,
wie `Index.cshtml`, `Create.cshtml`, etc.

Diese werden dann folgendermassen im Controller angesprochen:

````C#
public IActionResult Create()
{
    return View();
}
````

Um nun die Daten vom Model zu implementieren, müssen wir am Anfang des Files folgendes machen:

````Razor
@model MVC_Demo.Models.Apprentice
````

Mit diesem Statement importieren wir die Daten vom Model Apprentice.

## Tag-Helpers

Tag-Helpers ermöglichen es Server-Side Code HTML-Elemente zu kreieren und rendern. So können wir zum Beispiel Daten in Forms einfügen und sie mit
einem **POST**-Request speichern.

### Links

Bei Links gibt es verschiedene Tag-Helpers, die gängigsten sind:

- `asp-controller` - definiert den Controller, an welchen der User weitergeleitet werden soll
- `asp-action` - definiert die Methode in dem obigen Controller, an welcher der User weitergeleitet werden soll
- `asp-route-...` - gibt einer Methode im Controller ein Parameter mit, bspw. ID

### Forms

Bei Forms gibt es ebenfalls einige hilfreiche Tag-Helper:

- `asp-for` - definiert in welchem Attribut die Daten gespeichert bzw. von welchem Attribut gelesen werden soll
- `asp-validation-for` - zeigt die Fehlermeldungen für Inputs an
- `asp-validation-summary` - zeigt Fehler an, die zu keinem spezifischen Input gehören, also Fehlermeldungen, die im Controller erzeugt werden und
  nicht vom Modell kommen

Darüber hinaus ist es bei Forms, die die Daten modifizieren, wichtig auch die ID mitzugeben, wir können sie jedoch ausblenden:

````Razor
<input type="hidden" asp-for="ApprenticeId" />
````

## Client-Side-Validation

Um **Client-Side-Validation** zu aktivieren, können wir folgendes ans Ende von unserem File mit einem Form packen:

````Razor
@section Scripts {
    @ {
        <partial name="_ValidationScriptsPartial" />
    }
}
````