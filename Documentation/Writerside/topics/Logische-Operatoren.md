# Logische Operatoren

Logische Operatoren werden verwendet, um logische Operationen wie `AND`, `OR` durchzuführen. Logische Operatoren arbeiten mit booleschen
Ausdrücken (`true`
und `false`) und geben boolesche Werte zurück.

Logische Operatoren werden bei der Entscheidungsfindung und in Schleifen verwendet.

## Wahrheitstabelle

| Aussage 1 | Aussage 2 | AND     | OR      |
|-----------|-----------|---------|---------|
| `true`    | `true`    | `true`  | `true`  |
| `true`    | `false`   | `false` | `true`  |
| `false`   | `true`    | `false` | `true`  |
| `false`   | `false`   | `false` | `false` |

Einfach gesagt:

- Wenn mind. ein Operand `true` ist, dann wird der `OR`-Operator `true` zurückgeben
- Wenn mind. ein Operand `false` ist, dann wird der `AND`-Operator `false` zurückgeben

## Beispiel

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="logical.cs" /> 
    </tab>
    <tab title="Output">
        <code-block lang="c#">
            True
            False
        </code-block>
    </tab>
</tabs>