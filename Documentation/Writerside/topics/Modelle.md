# Modelle

Das Modell repräsentiert unsere Daten und ist verantwortlich für den Zugriff auf die Datenbank.

## Modell erstellen

Um ein Modell zu erstellen, fügen wir im Ordner <ui-path>Model</ui-path> eine Klasse hinzu, beispielsweise <ui-path>Apprentice.cs</ui-path>.

Im Model fügen wir alle Attribute ein, die für unsere Tabelle in der Datenbank essenziell sind:

````C#
[Key]
public int ApprenticeId { get; set; }

[Required(ErrorMessage = "Vorname ist ein Pflichtfeld")]
[StringLength(50, ErrorMessage = "Vorname darf maximal 50 Zeichen lang sein")]
[Display(Name = "Vorname")]
public string? FirstName { get; set; }

[Required(ErrorMessage = "Nachname ist ein Pflichtfeld")]
[StringLength(50, ErrorMessage = "Nachname darf maximal 50 Zeichen lang sein")]
[Display(Name = "Nachname")]
public string? LastName { get; set; }

[Required(ErrorMessage = "Adresse ist ein Pflichtfeld")]
[StringLength(100, ErrorMessage = "Adresse darf maximal 100 Zeichen lang sein")]
[Display(Name = "Adresse")]
public string? Address { get; set; }

[Required(ErrorMessage = "PLZ ist ein Pflichtfeld")]
[StringLength(10, ErrorMessage = "PLZ darf maximal 10 Zeichen lang sein")]
[Display(Name = "PLZ")]
public string? ZipCode { get; set; }

[Required(ErrorMessage = "Ort ist ein Pflichtfeld")]
[StringLength(50, ErrorMessage = "Ort darf maximal 50 Zeichen lang sein")]
[Display(Name = "Ort")]
public string? City { get; set; }

[Required(ErrorMessage = "Geburtsdatum ist ein Pflichtfeld")]
[Display(Name = "Geburtsdatum")]
public DateOnly BirthDate { get; set; }

[Required(ErrorMessage = "E-Mail ist ein Pflichtfeld")]
[EmailAddress(ErrorMessage = "Die E-Mail-Adresse hat nicht das richtige Format")]
[Display(Name = "E-Mail")]
public string? Email { get; set; }

[Required(ErrorMessage = "Telefonnummer ist ein Pflichtfeld")]
[Phone(ErrorMessage = "Die Telefonnummer hat nicht das richtige Format")]
[Display(Name = "Telefon")]
public string? Phone { get; set; }
````

Hier erstellen wir die einzelnen Attribute für die **Apprentice**-Tabelle.

### Data Annotations

Darüber hinaus können die Modelle mit **DataAnnotation** angepasst werden. Dort können wir beispielsweise festlegen, dass ein Feld `Required` ist.
Darüber hinaus können wir mit dem Argument `ErrorMessage` die Fehlermeldung festlegen, wenn diese Regel verletzt wird.

#### Liste der Data Annotations

| Code                    | Bedeutung                                              |
|-------------------------|--------------------------------------------------------|
| `[Key]`                 | Definiert Attribut als Primärschlüssel                 |
| `[ForeignKey]`          | Definiert ein Attribut als Fremdschlüssel              |
| `[Required]`            | Definiert ein Attribut als Pflichtfeld                 |
| `[DisplayName("Name")]` | Definiert das Label des Attributes in der gesamten App |
| `[Range(1000,9999)]`    | Definiert den Wertebereich einer Zahl                  |
| `[MinLength(10)]`       | Definiert die Mindestlänge eines Strings               |
| `[MaxLength(20)]`       | Definiert die Maximallänge eines Strings               |

## Modell registrieren

Damit das Modell vom Controller angesprochen werden kann, müssen wir das Modell noch registrieren. Das machen wir im <ui-path<
ApplicationDbContext.cs/ui-path>-File.

Dieses File ist die Schnittstelle zwischen den Modellen und der Datenbank. Die Klasse erbt von der `IdentityDbContext`-Klasse, welche Funktionen
enthält, um die Datenbank-Migration aus den Modellen zu erstellen.

Um nun unser Modell zu registrieren, geben wir folgendes nach dem Konstruktor ein:

````C#
public DbSet<Apprentice> Apprentices { get; set; }
````

## SQL Server konfigurieren

Für den nächsten Schritt müssen wir unseren SQL Server korrekt konfigurieren: [Konfiguration - SQL Server](Konfiguration-SQL-Server.md)

## Migrationen

Eine Migration in einer MVC-App bewirkt, dass die Datenbank mit den Modellen abgeglichen wird. Bei einer Migration werden die Modelle interpretiert
und in SQL-Code umgewandelt.

Um eine Migration zu machen, öffnen wir die **Package-Manager-Konsole** über <ui-path>Extras | NuGet-Paket-Manager</ui-path>. In der Konsole geben wir
nun folgenden Befehl ein:

````Console
add-migration NameOfMigration
````

> Dieser erstellt ein neues Migrationsfile mit dem Namen, den wir mitgegeben haben. Dieses File wird unter <path>Data\Migrations</path> abgelegt.
>
> So kann bei Bedarf auch auf alte Stände zurückgesetzt werden, `remove-migration`.
>
> Darüber hinaus können Migrationen nur erstellt werden, wenn die Applikation keine Buildfehler mehr aufweist.

Um nun die Datenbank zu aktualisieren, müssen wir noch folgenden Befehl ausführen:

````Console
update-database
````

Dies führt die Funktion `protected override void Up()` im Migrationsfile aus und nimmt Änderungen an der Datenbank vor.