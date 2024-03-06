# while Loop

Der `while`- und `do...while`-Loop sind nochmals zwei verschiedene Arten von Loops. Den `for`-Loop benutzt man vor allem dann, wenn man **genau
weiss**, wie oft man iterieren möchte. Die `while`- und `do...while`-Loops werden dann verwendet, wenn man **nicht genau weiss wie oft** etwas
wiederholt werden sollte, bspw. ein "Errate die Zahl"-Spiel. Ausserdem braucht man keine Zählervariable wie bei `for`-Loops.

## while Loop

Der `while`-Loop überprüft eine Kondition am Anfang, d.h. ein `while`-Loop kann auch kein einziges Mal ausgeführt werden.

### Syntax - while Loop

Die Syntax des `while`-Loops sieht folgendermassen aus:

````C#
while (condition)
{
	// body of while
}
````

- Der `while`-Loop besteht aus einer `condition`
- **Wenn die `condition` `true` ist:**
    - Die Anweisungen im `while`-Loop werden ausgeführt
    - Nach der Ausführung wird die `condition` erneut ausgewertet
- **Wenn die `condition` `false` ist:**
    - Der `while`-Loop wird nicht mehr ausgeführt

### Beispiel - while Loop

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="while.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            C# While Loop: Iteration 1
            C# While Loop: Iteration 2
            C# While Loop: Iteration 3
            C# While Loop: Iteration 4
            C# While Loop: Iteration 5
        </code-block>
    </tab>
</tabs>

## do...while Loop

Der `do...while`-Loop wird, im Gegensatz zum `while`-Loop, mindestens einmal ausgeführt, da die Kondition erst am Ende geprüft wird.

### Syntax - do...while Loop

Die Syntax des `while`-Loops sieht folgendermassen aus:

````C#
do
{
    // body of do while loop
} while (condition);
````

- Zuerst wird der Inhalt der `do...while`-Schleife ausgeführt.
- Danach wird die `condition` ausgewertet.
- **Wenn die `condition` `true` ist:**
    - Die Anweisungen im `do...while`-Loop werden ausgeführt
    - Nach der Ausführung wird die `condition` erneut ausgewertet
- **Wenn die `condition` `false` ist:**
    - Der `while`-Loop wird nicht mehr ausgeführt

### Beispiel - do...while Loop

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="doWhile.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            5 * 1 = 5
            5 * 2 = 10
            5 * 3 = 15
            5 * 4 = 20
            5 * 5 = 25
            5 * 6 = 30
            5 * 7 = 35
            5 * 8 = 40
            5 * 9 = 45
            5 * 10 = 50
        </code-block>
    </tab>
</tabs>