# Unary Operatoren

Im Gegensatz zu anderen Operatoren arbeiten die unary Operatoren mit einem einzigen Operanden.

| Operator | Operator-Name     | Beschreibung                                   |
|----------|-------------------|------------------------------------------------|
| `+`      | Unary Plus        | Lässt das Vorzeichen des Operanden unverändert |
| `-`      | Unary Minus       | Invertiert das Vorzeichen des Operanden        |
| `++`     | Inkrement         | Wert um 1 erhöhen                              |
| `--`     | Verkleinern       | Wert um 1 verringern                           |
| `!`      | Logische Negation | Invertiert den Wert eines Boolean              |

## Beispiel

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="unary.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            +number = 10
            -number = -10
            ++number = 11
            --number = 10
            !flag = False
        </code-block>
    </tab>
</tabs>

## Prä- vs. Postfix

Die Operatoren Inkrement (`++`) und Dekrement (`--`) können als Präfix und Postfix verwendet werden. Wenn sie als Präfix verwendet werden, wird die
Änderung des Variablenwerts in der gleichen Zeile angezeigt, und wenn sie als Postfix verwendet werden, wird die Änderung des Variablenwerts in der
nächsten Zeile angezeigt. Dies wird anhand des folgenden Beispiels deutlich:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="prefix-postfix.cs" />
    </tab>  
    <tab title="Output">
        <code-block lang="bash">
            10
            11
            12
            12
        </code-block> 
    </tab>

</tabs>