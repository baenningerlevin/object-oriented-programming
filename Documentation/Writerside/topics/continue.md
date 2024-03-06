# continue

Mit dem `continue`-Statement können wir eine Iteration überspringen. Diese Anweisung wird oft im Zusammenhang mit `if...else`-Blöcken
gebraucht, um in einem Loop auf eine bestimmte Kondition zu testen.

Das `continue`-Statement kann mit allen möglichen Loops verwendet werden: [_C# `for`-Loop_](for-Loop.md), [_C # `while`-Loop_](while-Loop.md) und
[_C# `foreach`-Loop_](foreach-Loop.md).

## Beispiel

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="continue.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            1
            2
            4
            5
        </code-block>
    </tab>
</tabs>

Hier wird die `3` übersprungen, da wir dass mit dem `if`-Statement festgelegt haben.