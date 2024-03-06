# Input/Output

## Output

Um etwas in C# auszugeben, können wir folgende zwei Methoden verwenden:

````C#
System.Console.WriteLine()
System.Console.Write()
````

### Unterschied zwischen WriteLine() und Write()

Der Hauptunterschied zwischen `WriteLine()` und `Write()` besteht darin, dass die `Write()`-Methode nur die ihr übergebene Zeichenkette ausgibt,
während die `WriteLine()`-Methode die Zeichenkette ausgibt und auch zum Anfang der nächsten Zeile übergeht.

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="output.cs" />
    </tab>  
    <tab title="Output">
        <code-block lang="bash">
            Prints on
            New line
            Prints on Same line
        </code-block>
    </tab>
</tabs>

### Ausgeben von Variablen und Literalen

Die Methoden `WriteLine()` und `Write()` können verwendet werden, um Variablen und Literale auszugeben. Hier ist ein Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="outputVariables.cs" />
    </tab>  
    <tab title="Output">
        <code-block lang="bash">
            10
            50.05
        </code-block>
    </tab>
</tabs>

### Verketten von zwei Strings

#### Der + Operator

Strings können mithilfe des `+`-Operator miteinander verkettet werden:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="concatenating.cs" />
    </tab>  
    <tab title="Output">
        <code-block lang="bash">
            Hello World
            Value = 55
        </code-block>
    </tab>
</tabs>

#### Formatierte Strings

Eine bessere Alternative für das Ausgeben einer verketteten Zeichenfolge ist die Verwendung eines formatierten Strings. Der formatierte String erlaubt
es dem Programmierer, Platzhalter für Variablen zu verwenden. Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="stringFormatting.cs" />
    </tab>  
    <tab title="Output">
        <code-block lang="bash">
            5 + 10 = 15
        </code-block>
    </tab>
</tabs>

## Input

In C# ist die einfachste Methode, Eingaben vom Benutzer zu erhalten, die `ReadLine()`-Methode der `Console`-Klasse. `Read()` und `ReadKey()` sind
jedoch
auch
verfügbar, um Eingaben vom Benutzer zu erhalten. Sie sind ebenfalls in der `Console`-Klasse enthalten.

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="input.cs" />
    </tab>  
    <tab title="Output">
        <code-block lang="bash">
            Enter a string - Hello World
            You entered 'Hello World'
        </code-block>
    </tab>
</tabs>

### Unterschiede zwischen ReadLine(), Read() und ReadKey()

Der Unterschied zwischen der `ReadLine()`, `Read()` und `ReadKey()`-Methode ist:

- `ReadLine()`: Die Methode ReadLine() liest die nächste Eingabezeile aus dem **Standard Input Stream**. Sie gibt den gleichen String zurück.
- `Read()`: Die Methode Read() liest das nächste Zeichen aus dem Standard Input Stream. Sie gibt den ASCII-Wert des Zeichens zurück.
- `ReadKey()`: Die Methode ReadKey() ermittelt die nächste vom Benutzer gedrückte Taste. Diese Methode wird normalerweise verwendet, um den Bildschirm
  zu halten, bis der Benutzer eine Taste drückt.