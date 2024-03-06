# foreach Loop

C# bietet uns eine einfachere und lesbarere Alternative zum `for`-Loop, den `foreach`-Loop. Dieser wird zum Iterieren von Arrays und Collections
verwendet. Der `foreach`-Loop iteriert über jedes Element.

## Syntax

Die Syntax des `foreach`-Loops sieht folgendermassen aus:

````C#
foreach (element in iterable-item)
{
    // body of foreach loop
}
````

## Diagramm

![](https://cdn.programiz.com/sites/tutorial2program/files/csharp-foreach-flowchart.jpg) { width="350" thumbnail="true" }

Das `in` Keyword wird benutzt, um über das `iterable-item` zu iterieren. Das `in` Keyword wählt bei jeder Iteration ein Item von dem
`iterable-item` aus und speichert es in der Variable `element`.

## Beispiel

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="foreach.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Number of male = 6
            Number of female = 4
        </code-block>
    </tab>
</tabs>