# break

Wir können die `break` Anweisung verwenden, um den Loop sofort zu beenden. Diese Anweisung wird oft im Zusammenhang mit `if...else`-Blöcken
gebraucht, um in einem Loop auf eine bestimmte Kondition zu testen.

Das `break`-Statement kann mit allen möglichen Loops verwendet werden: [_C# `for`-Loop_](for-Loop.md), [_C # `while`-Loop_](while-Loop.md) und
[_C# `foreach`-Loop_](foreach-Loop.md).

## Beispiel

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="break.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            1
            2
        </code-block>
    </tab>
</tabs>

Hier brechen wir den Loop ab, sobald `i` `3` erreicht hat. Deshalb werden auch nur `1` und `2` ausgegeben.