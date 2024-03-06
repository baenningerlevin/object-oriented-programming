# Methoden

Eine Methode ist ein Codeblock, der eine bestimmte Aufgabe ausführt. Nehmen wir an, du musst ein Programm erstellen, dass einen Kreis erzeugt und ihn
einfärbt. Du kannst zwei Methoden erstellen, um dieses Problem zu lösen:

- eine Methode zum Zeichnen des Kreises
- eine Methode zur Einfärbung des Kreises

Die Aufteilung eines komplexen Problems in kleinere Teile macht Ihr Programm leicht verständlich und wiederverwendbar.

## Deklaration von Methoden

Die Syntax zum Deklarieren einer Methode sieht so aus:

````C#
returnType MethodName() {
  // method body
}
````

- **`returnType`** - Gibt an, welchen Typ von Wert eine Methode zurückgibt. Wenn eine Methode zum Beispiel den Rückgabetyp `int` hat, gibt die Methode
  eine Ganzzahl zurück.
- **`MethodName`** - Das ist der Bezeichner, der verwendet wird, um auf diese bestimmte Methode im Programm zu verweisen.
- **Inhalt der Methode** - Dieser Teil enthält die Anweisungen, die ausgeführt werden sollen.

Zum Beispiel:

````C#
void Display()
{
    // Code
}
````

Der Name der Methode lautet `Display()` und gibt **nichts** also `void` zurück.

## Aufrufen von Methoden

Wir können die Methode mit dem Namen der Methode aufrufen:

````C#
Display();
````

## Rückgabetyp

Eine Methode kann, muss aber nicht, einen Wert zurückgeben. Dafür benutzen wir das `return`-Keyword. Zum Beispiel:

````C#
int AddNumbers() 
{
  ...
  return sum;
}
````

## Parameter

In C# können wir einer Methode auch sogenannte Parameter mitgeben. Beispielsweise:

````C#
int AddNumber(int a, int b) 
{
  // Code
}
````

Hier sind `a` und `b` Parameter der `AddNumber()`-Methode. Wenn eine Methode mit Parametern erstellt wird, müssen die entsprechenden Werte (Argumente)
beim Aufruf der Methode übergeben werden. Zum Beispiel:

````C#
AddNumber(100, 100);
````

### Standard-Parameter

Wir können Parametern auch Standardwerte mitgeben, die benutzt werden, falls beim Aufruf der Funktion ein Argument nicht mitgegeben wird:

````C#
int AddNumber(int a = 0, int b = 0) 
{
  // Code
}
````

### Benannte Argumente

Es ist möglich Argumente mit der `key: value` Syntax zu versehen. Mit ihnen spielt die Reihenfolge der Argumente keine Rolle mehr:

````C#
int AddNumber(int a, int b) 
{
  // Code
}

AddNumber(b: 4, a: 1);
````

### Beispiel für Methoden mit Parametern

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="methods.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Sum: 200
        </code-block>
    </tab>
</tabs>
