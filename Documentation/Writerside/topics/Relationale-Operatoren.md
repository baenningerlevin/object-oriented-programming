# Relationale Operatoren

Relationale Operatoren werden verwendet, um die Beziehung zwischen zwei Operanden zu prüfen. Wenn die Beziehung wahr ist, ist das Ergebnis `true`,
andernfalls ist es `false`.

Relationale Operatoren werden bei der Entscheidungsfindung und in Schleifen verwendet.

| Operator | Operator-Name        | Beispiel                |
|----------|----------------------|-------------------------|
| `==`     | Equal to             | `6 == 4` ergibt `false` |
| `>`      | Grösser als          | `3 > -1` ergibt `true`  |
| `<`      | Kleiner als          | `5 < 3` ergibt `false`  |
| `>=`     | Grösser oder gleich  | `4 >= 4` ergibt `true`  |
| `<=`     | Kleiner order gleich | `5 <= 3` ergibt `false` |
| `!=`     | Nicht gleich         | `10 != 2` ergibt `true` |

## Beispiele

<tabs>
    <tab title="C#">
        <code-block src="relational.cs" lang="c#" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            <![CDATA[
                10 == 20 returns False
                10 > 20 returns False
                10 < 20 returns True
                10 >= 20 returns False
                10 <= 20 returns True
                10 != 20 returns True
            ]]>
        </code-block>
    </tab>
</tabs>