# Typenkonversion

Der Vorgang der Konvertierung des Werts eines Typs (`int`, `float`, `double` usw.) in einen anderen Typ wird als Typenkonvertierung bezeichnet.

In C# gibt es zwei grundlegende Arten der Typenkonvertierung:

1. **Implizite Typenkonvertierungen**
2. **Explizite Typenkonvertierungen**

## Implizite Typenkonvertierung

Bei der impliziten Typenkonvertierung wird ein kleinerer Datentyp automatisch in einen grösseren Datentypen verwandelt. Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="implicit.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            numInt value: 500
            numInt Type: System.Int32
            numDouble value: 500
            numDouble Type: System.Double
        </code-block>
    </tab>
</tabs>

Hier wandelt der Compiler den `int` Typ automatisch in eine `double` Typ um.

## Explizite Typenkonvertierung

Bei der expliziten Typenkonvertierung konvertieren wir explizit einen Typ in einen anderen. Im Allgemeinen werden größere Typen wie `double` in
kleinere Typen wie `int` konvertiert. Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="implicit.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Original double value: 1.23
            Converted int value: 1
        </code-block>
    </tab>
</tabs>

In diesem Beispiel, wandeln wir den `double`-Typ in einen `int`-Typ um, indem wir die **cast-expression** `(int)` vor den Datentypen setzen.

Da wir hier den Datentypen verkleinern haben wir einen Datenverlust. In diesem Beispiel verlieren wir die Kommazahlen des `double`-Typen.

### Parse()

Eine andere Möglichkeit explizite Typenkonvertierung zu machen ist mit der `Parse()`-Methode. Diese wird vor allem, bei nicht-kompatiblen Typen,
wie `int` und `string` verwendet.

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="parse.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Original string value: 100
            Converted int value: 100
        </code-block>
    </tab>
</tabs>

### Convert

Eine weiter möglichkeit explizite Typenkonvertierung durchzuführen ist mit der `Convert`-Klasse. Sie stellt uns verschiedene Methoden bereit, um
Typenkonvertierung zu ermöglichen.

| Methode       | Beschreibung                                    |
|---------------|-------------------------------------------------|
| `ToBoolean()` | Konvertiert einen Typen zu einem `Boolean`-Wert |
| `ToChar()`    | Konvertiert einen Typen zu einem `char`-Wert    |
| `ToDouble()`  | Konvertiert einen Typen zu einem `double`-Wert  |
| `ToInt16()`   | Konvertiert einen Typen zu einem `short`-Wert   |
| `ToInt32()`   | Konvertiert einen Typen zu einem `int`-Wert     |
| `ToInt64()`   | Konvertiert einen Typen zu einem `long`-Wert    |
| `ToString()`  | Konvertiert einen Typen zu einem `string`-Wert  |

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="convert.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            int value: 100
            string value: 100
            double value: 100
        </code-block>
    </tab>
</tabs>