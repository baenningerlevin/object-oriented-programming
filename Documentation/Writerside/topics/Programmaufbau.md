# Programmaufbau

Das Programm "Hallo Welt!" ist oft das erste Programm, das wir sehen, wenn wir in eine neue Sprache eintauchen. Es gibt einfach "Hallo Welt!" auf dem
Ausgabebildschirm aus.

Ziel dieses Programms ist es, uns mit der grundlegenden Syntax und den Anforderungen einer Programmiersprache vertraut zu machen.

## Programmaufbau in C#

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="helloWorld.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Hello World!
        </code-block>
    </tab>
</tabs>

**1. `using System`**

Diese Zeile ermöglicht es uns [_Klassen_](Klassen-und-Objekte.md)
des [`System`-Namespaces](https://learn.microsoft.com/en-us/dotnet/api/system?view=net-8.0) zu nutzen.

Einfach gesagt sind **Namespaces** Container für Klassen, Methoden, Enums, etc. Mit dem Keyword `using` können wir dem Programm mitteilen, dass wir
diesen Namespace in diesem File nutzen wollen.

**2. `namespace HalloWelt {...}`**

Das `namespace`-Schlüsselwort wird verwendet, um unseren eigenen Namespace zu definieren. Hier erstellen wir einen Namespace namens `HelloWorld`.

Du kannst dir einen Namespace als Container vorstellen, welcher aus [_Klassen_](Klassen-und-Objekte.md), [_Methoden_](Methoden.md) und weiteren
Namespaces besteht.

**3. `class Program {...}`**

Die obige Anweisung erstellt eine _[Klasse](Klassen-und-Objekte.md)_ namens `Program`.

Da es sich bei C# um eine objektorientierte Programmiersprache handelt, ist die Erstellung einer Klasse für die Ausführung des Programmes unbedingt
notwendig.

**4. `static void Main(string[] args) {...}`**

`Main()` ist eine _[Methode](Methoden.md)_ der Klasse `Program`. Die Ausführung eines jeden C#-Programms beginnt mit der Methode `Main()`. Ein
C#-Programm muss also zwingend eine `Main()` Methode haben.

Die Signatur der `Main()`-Methode lautet:

   ```C#
   static void Main(string[] args){ ... }
   ```

**5. `Console.WriteLine("Hello World!")`**

`Console` ist eine Klasse des `System`-Namespaces, welche eine Methode besitzt, mit welcher wir Text ausgeben können. In diesem Fall wird der
String `Hello World!` ausgegeben
