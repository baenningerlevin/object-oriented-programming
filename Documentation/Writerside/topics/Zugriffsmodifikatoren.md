# Zugriffsmodifikatoren

In C# legen Zugriffsmodifikatoren die Zugänglichkeit von Typen (Klassen, Interfaces usw.) und Typ-Members (Eigenschaften, Methoden usw.) fest. Zum
Beispiel:

````C#
class Student 
{
  public string Name;
  private int _num;
}
````

- `Name` - öffentliche Eigenschaft, auf die von überall zugegriffen werden kann
- `_num` - private Eigenschaft, auf welche nur in der `Student`-Klasse zugegriffen werden kann

## Öffentlicher Zugriffsmodifikator

Wenn wir einen Member als `public` deklarieren, kann auf diesen von überall aus zugegriffen werden. Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="public.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Name: Sheeran
            Hello from Student class
        </code-block>
    </tab>
</tabs>

## Privater Zugriffsmodifikator

Wenn wir einen Member mit dem `private` Zugriffsmodifikator deklarieren, kann auf diesen nur innerhalb derselben `class` oder `struct` zugegriffen
werden.

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="private.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Error    CS0122    'Student._name' is inaccessible due to its protection level    
            Error    CS0122    'Student._print()' is inaccessible due to its protection level  
        </code-block>
    </tab>
</tabs>

## Geschützter Zugriffsmodifikator

Wenn wir einen Member als `protected` deklarieren, kann auf diesen nur von derselben Klasse und von allen abgeleiteten Klassen zugegriffen werden.

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="protected.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Error    CS0122    'Student.name' is inaccessible due to its protection level    
        </code-block>
    </tab>
</tabs>

Von der Klasse `Program` aus können wir nicht auf das geschützte Property zugreifen. Jedoch kann es das, wenn die `Program`-Klasse die Member erbt:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="protectedDerived.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Name: Sheeran
        </code-block>
    </tab>
</tabs>

## Interner Zugriffsmodifikator

Wenn wir einen Member als `internal` deklarieren, kann nur innerhalb des gleichen Assembly darauf zugegriffen werden.

Ein Assembly ist eine Sammlung von Typen (Klassen, Schnittstellen usw.) und Ressourcen (Daten). Sie sind so aufgebaut, dass sie zusammenarbeiten und
eine
logische Einheit der Funktionalität bilden.

Wenn wir ein Assembly ausführen, werden daher alle Klassen und Schnittstellen innerhalb der Assembly gemeinsam ausgeführt. Um mehr zu erfahren,
besuche [C# Assembly](https://learn.microsoft.com/en-us/dotnet/standard/assembly/).

## Mischformen

Darüber hinaus gibt es noch Mischformen, wie `protected internal`, etc. Hier verweise ich auf folgende
Seite: [C# Access Modifiers](https://www.programiz.com/csharp-programming/access-modifiers)