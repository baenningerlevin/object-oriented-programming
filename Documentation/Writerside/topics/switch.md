# switch

Das `switch`-Statement ist eine Alternative zu dem [`if...else if`-Statement](if-else.md#if-else-if-statement). Mit dem `switch`-Statement sieht der
Code viel aufgeräumter und lesbarer aus.

Die Syntax ist Folgende:

````C#
switch (variable/expression)
{
    case value1:
        // Statements executed if expression(or variable) = value1
        break;
    case value2:
        // Statements executed if expression(or variable) = value1
        break;
    ... ... ... 
    ... ... ... 
    default:
        // Statements executed if no case matches
}
````

Das `switch`-Statement wertet den Ausdruck (oder die Variable) aus und vergleicht sie mit den Werten (oder Ausdrücken) von jedem `case`. Wenn es den
passenden Wert findet, werden die Anweisungen in diesem `case` ausgeführt.

Wenn kein `case` mit dem Ausdruck übereinstimmt, werden die Anweisungen im `default`-Statement ausgeführt.

> In jedem `case` müssen wir am Ende ein `break;` hinschreiben, ansonsten werden **alle** `case` danach, ebenfalls ausgeführt.

{ style="warning" }

## Beispiel

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="switch.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Enter first number: -13.11
            Enter second number: 2.41
            Enter operator (+, -, *, /): *
            -13.11 * 2.41 = -31.5951
        </code-block>
    </tab>
</tabs>
