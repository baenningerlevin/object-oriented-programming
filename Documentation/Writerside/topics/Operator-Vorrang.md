# Operator-Vorrang

## Präzedenz

Der Vorrang von Operatoren ist eine Reihe von Regeln, die festlegen, wie ein Ausdruck ausgewertet wird. In C# hat jeder C#-Operator eine zugewiesene
Priorität und basierend auf diesen Prioritäten wird der Ausdruck ausgewertet.

Zum Beispiel ist der Vorrang des Multiplikationsoperators (`*`) höher als der Vorrang des Additionsoperators (`+`). Daher werden Operationen, die eine
Multiplikation beinhalten, vor der Addition ausgeführt.

Zum Beispiel:

````C#
int x = 4 + 3 * 5;
````

Wie hoch ist der Wert von `x` nach Ausführung dieser Anweisung?

Der Operand `3` ist mit `+` und `*` verbunden. Wie bereits erwähnt, hat die Multiplikation einen höheren Vorrang als die Addition. Daher wird die
Operation
`3 * 5` anstelle von `4 + 3` ausgeführt. Der Wert der Variablen `x` wird `19` sein.

Hätte die Addition einen höheren Vorrang, würde `4 + 3` zuerst ausgewertet werden und der Wert von `x` wäre `35`.

### Operator-Präzedenztabelle

Je höher der Vorrang eines Operators ist, desto weiter oben steht er in der Tabelle:

| Kategorie       | Operator                          |
|-----------------|-----------------------------------|
| Postfix         | `++`, `--`                        |
| Präfix, Unär    | `++`, `--`, `+`, `-`, `!`         |
| Multiplikativ   | `*`, `/`, `%`                     |
| Additiv         | `+`, `-`                          |
| Relational      | `<`, `<=`, `>`, `>=`              |
| Gleichheit      | `==`, `!=`                        |
| Logisches `AND` | `&&`                              |
| Logische `OR`   | `                                 ||`                      |
| Ternär          | `? :`                             |
| Zuweisung       | `=`, `+=`, `-=`, `*=`, `/=`, `%=` |

## Assoziativität

Im vorangegangenen Abschnitt haben wir über den Vorrang von Operatoren gesprochen. Wenn zwei Operatoren mit unterschiedlichem Vorrang verwendet
werden, wird der Operator mit dem höheren Vorrang zuerst ausgewertet.

Was aber, wenn beide Operatoren den gleichen Vorrang haben?

In diesem Fall wird der Ausdruck auf der Grundlage der Assoziativität des Operators (von links nach rechts oder von rechts nach links) bewertet.

Zum Beispiel:

````C#
int a = 5, b = 6, c = 3; 
int result = a * b / c;
````

Hier haben sowohl `*` als auch `/` den gleichen Vorrang. Da aber die Assoziativität dieser Operatoren von links nach rechts verläuft, wird
zuerst `a * b`ausgewertet und dann die Division durchgeführt. Das Endergebnis dieses Ausdrucks ist `10`.

In diesem speziellen Beispiel ist die Assoziativität nicht wirklich von Bedeutung. Denn selbst wenn die Division vor der Multiplikation durchgeführt
würde, bliebe das Ergebnis davon unberührt.

Schauen wir uns ein anderes Beispiel an.

````C#
int a = 5, b = 6, c = 3; a = b = c;
````

Die Assoziativität des `=`-Operators ist von rechts nach links. Der Wert von `c` (d.h. `3`) wird also `b` zugewiesen, und dann wird der Wert
von `b` `a`
zugewiesen. Nach der Ausführung dieser Anweisung werden die Werte von `a`, `b` und `c` also `3` sein.

### Operator-Assoziativitätstabelle

Die folgende Tabelle zeigt die Assoziativität der C#-Operatoren:

| Kategorie       | Operator                          | Assoziativität        |
|-----------------|-----------------------------------|-----------------------|
| Postfix         | `++`, `--`                        | Von links nach rechts |
| Präfix, Unär    | `++`, `--`, `+`, `-`, `!`         | Von rechts nach links |
| Multiplikativ   | `*`, `/`, `%`                     | Von links nach rechts |
| Additiv         | `+`, `-`                          | Von links nach rechts |
| Relational      | `<`, `<=`, `>`, `>=`              | Von links nach rechts |
| Gleichheit      | `==`, `!=`                        | Von links nach rechts |
| Logisches `AND` | `&&`                              | Von links nach rechts |
| Logische `OR`   | `                                 |                       |`                              |  Von rechts nach links                               
| Ternär          | `? :`                             | Von rechts nach links |
| Zuweisung       | `=`, `+=`, `-=`, `*=`, `/=`, `%=` | Von rechts nach links |
