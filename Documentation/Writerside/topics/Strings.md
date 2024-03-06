# Strings

Ein String ist eine Sequenz von Zeichen, bspw. ist `"Hello"` ein String mit den Zeichen `'H'`, `'e'`, `'l'`, `'l'` und `'o'`.

Wir nutzen das `string` Keyword um einen String zu erstellen:

````C#
string str = "C# Programming";
````

> Der String ist kein normaler primitiver Typ, sondern ein Objekt der Klasse `String`

## String Operationen

### Property - Length

Um die Länge eines Strings herauszufinden, nutzen wir das `Length` Property:

<tabs>
    <tab title="C#">
       <code-block lang="c#">
            string firstName = "Levin";
            Console.WriteLine($"{firstName} has {firstName.Length} characters";
        </code-block> 
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Levin has 5 characters
        </code-block>
    </tab>
</tabs>

### Methode - Concat()

Mit der `Concat()`-Methode können wir zwei Strings zusammenfügen:

<tabs>
    <tab title="C#">
       <code-block lang="c#" src="concat.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Levin Baenninger
        </code-block>
    </tab>
</tabs>

### Methode - Equals()

Mit der `Equals()`-Methode können wir überprüfen, ob zwei Strings identisch sind oder nicht.

<tabs>
    <tab title="C#">
       <code-block lang="c#" src="equals.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            string str1 and str2 are equal: True
            string str1 and str3 are equal: False
        </code-block>
    </tab>
</tabs>

### Methode - toUpper() / toLower()

Mit den beiden Methoden `toUpper()` und `toLower()` können wir Strings formatieren:

<tabs>
    <tab title="C#">
       <code-block lang="c#" src="toUpperToLower.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            C# PROGRAMMING
            c# programming
        </code-block>
    </tab>
</tabs>

## Escape Sequenzen

Escape Sequenzen werden verwendet, um bestimmte Zeichen zu schreiben, die normalerweise nicht möglich wären, bspw. `"`.

| Escape-Sequenz | Zeichenname         |
|----------------|---------------------|
| `\'`           | Hochkomma           |
| `\"`           | Doppelte Hochkommas |
| `\\`           | Backslash           |
| `\0`           | null                |
| `\n`           | Zeilenumbruch       |
| `\t`           | Tabstopp            |
