# Ternary Operator

Der Ternary Operator ist eine alternative Schreibweise zum `if-else`-Statement. Die Syntax sieht wie folgt aus:

````C#
Condition ? Expression1 : Expression2;
````

Der Ternary Operator funktioniert wie folgt:

- Wenn der Ausdruck von `condition` wahr ist, dann wird das Resultat von `Expression1` zurückgegeben.
- Wenn der Ausdruck `false` ist, dann wird das Resultat von `Expression2` zurückgegeben.

## Beispiel

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="ternary.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            True
        </code-block>
    </tab>

</tabs>