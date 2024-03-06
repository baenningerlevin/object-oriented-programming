# for Loop

In der Programmierung ist es oft erwünscht, einen bestimmten Block von Anweisungen eine bestimmte Anzahl von Malen auszuführen. Eine mögliche
Lösung besteht darin, diese Anweisungen so oft wie nötig einzugeben. Es kann jedoch sein, dass die Anzahl der Wiederholungen nicht im Voraus
bekannt ist (während der Kompilierung) oder vielleicht zu gross ist (z.B. 10000).

Die beste Lösung für ein solches Problem ist eine Schleife. Schleifen werden in der Programmierung verwendet, um einen bestimmten Block von
Anweisungen wiederholt auszuführen, bis eine bestimmte Bedingung erfüllt ist.

## Syntax

Die Syntax des `for`-Loops sieht folgendermassen aus:

````C#
for (initialization; condition; iterator)
{
	// body of for loop
}
````

Der `for`-Loop hat drei Anweisungen: `initialization`, `condition` und `iterator`.

- Die `initialization` wird zuerst und nur einmal ausgeführt, hier wird oft eine Variable erstellt.
- Danach wird die `condition` überprüft. Die `condition` ist ein Boolean und gibt `true` oder `false` zurück.
- **Wenn die `condition` `true` ist:**
  - Die Anweisungen innerhalb des Loops werden ausgeführt
  - Dann wird die `iterator`-Anweisung durchgeführt, un ändert den Wert der initialisierten Variable
  - Danach wird die `condition` erneut überprüft, bis diese `false` zurückgibt
- **Wenn die `condition` `false` ist:**
  - Der Loop wird abgebrochen und es wird im Programm fortgefahren

## Beispiel

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="for.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            C# For Loop: Iteration 1
            C# For Loop: Iteration 2
            C# For Loop: Iteration 3
            C# For Loop: Iteration 4
            C# For Loop: Iteration 5
        </code-block>
    </tab>
</tabs>