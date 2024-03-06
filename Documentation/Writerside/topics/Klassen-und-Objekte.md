# Klassen und Objekte

C# ist eine objektorientierte Programmiersprache. Bei der objektorientierten Programmierung (OOP) lösen wir komplexe Probleme, indem wir sie in
Objekte unterteilen.

Um mit Objekten zu arbeiten, müssen wir die folgenden Dinge durchführen:

- eine **Klasse** erstellen
- **Objekte** aus der Klasse erstellen

## Klasse

Bevor wir etwas über Objekte lernen, müssen wir die Funktionsweise von Klassen verstehen. Eine Klasse ist der Bauplan oder die Skizze für ein Objekt.

Wir können uns die Klasse als eine **Skizze** (Prototyp) **eines Hauses** vorstellen. Sie enthält alle Details über die Böden, Türen, Fenster usw. Auf
der Grundlage dieser Beschreibungen können wir ein Haus bauen. Das **Haus** ist das Objekt.

So wie aus einer Skizze viele Häuser gemacht werden können, können wir aus einer Klasse viele Objekte erstellen.

### Eine Klasse erstellen

Wir verwenden das Schlüsselwort `class`, um ein Objekt zu erstellen. Zum Beispiel:

````C#
class ClassName 
{ 

}
````

Hier haben wir eine Klasse namens `ClassName` erstellt. Eine Klasse kann Folgendes enthalten:

- **Eigenschaften** - Variablen zum Speichern von Daten
- **Methoden** - Funktionen zur Durchführung bestimmter Aufgaben

Am besten sehen wir uns dazu ein Beispiel an:

````C#
class Dog 
{
  //field
  string breed;
 
  //method
  public void Bark() 
  {

  }
}
````

> In C# werden die Eigenschaften und Methoden in einer Klasse als **Member** einer Klasse bezeichnet

## Objekte

Ein Objekt ist eine Instanz einer Klasse. Nehmen wir an, wir haben eine Klasse `Dog`. Bulldogge, Deutscher Schäferhund, Mops sind Objekte der Klasse.

### Erstellen eines Objekts

Mithilfe des Keywords `new` können wir ein Objekt erstellen:

````C#
ClassName obj = new ClassName();
````

In unserem Beispiel könnte die Erstellung eines Objekts so aussehen:

````C#
Dog bullDog = new Dog();
````

Jetzt kann das `bullDog`-Objekt auf alle Eigenschaften und Methoden der `Dog`-Klasse zugreifen.

### Auf die Member der Klasse zugreifen

Mithilfe des `.`-Operators können wir auf die Member einer Klasse zugreifen:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="classesObjects.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Bull Dog 
            Woof, Woof!
        </code-block>
    </tab>

</tabs>

### Mehrere Objekte aus einer Klasse erstellen

Natürlich können wir mehr als ein Objekt pro Klasse erstellen:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="multipleObjects.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Sheeran: Development
            Taylor: Content Writing
        </code-block>
    </tab>
</tabs>

Wie du siehst haben beide Objekte deren eigene Version der `department` Eigenschaft mit verschiedenen Werten.

### Objekte in anderen Klassen erstellen

In C# können wir ebenfalls Objekte in einer anderen Klasse erstellen:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="otherClass.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Employee 1
            Name: Gloria
            Work: Coding
        </code-block>
    </tab>
</tabs>

Im oberen Beispiel haben wir zwei Klassen: `Employee` und `EmployeeDrive`. Hier erstellen wir ein Objekt `e1` aus der `Employee`-Klasse in
der `EmployeeDrive`-Klasse.

Wir haben das `e1`-Objekt benutzt, um auf die Member der `Employee`-Klasse in der Klasse `EmployeeDrive` zuzugreifen. Das ist möglich, da die Member
in der `Employee`-Klasse `public` sind. Mehr zu `public`
hier: [_C# Zugriffsmodifikatoren - Public_](Zugriffsmodifikatoren.md#ffentlicher-zugriffsmodifikator)