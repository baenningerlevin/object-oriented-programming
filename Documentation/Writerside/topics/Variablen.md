# Variablen

Eine Variable ist ein symbolischer Name für eine Speicherstelle im Arbeitsspeicher. Variablen werden verwendet, um Daten in einem Computerprogramm zu
speichern.

## Variablen deklarieren

Hier ist ein Beispiel für die Deklaration einer Variablen in C#:

````C#
int age;
````

In diesem Beispiel wird eine Variable `age` vom _[Datentyp](Primitive-Datentypen.md)_ `int` (Ganzzahl) deklariert, die nur ganzzahlige Werte speichern
kann.

Wir können der Variablen später in unserem Programm einen Wert zuweisen, genannt **initialisieren**, etwa so:

````C#
int age;
... ... ...
age = 24;
````

Die Variable kann aber auch bei der Deklaration mit einem Wert initialisiert werden. Zum Beispiel:

````C#
int age = 24;
````

Hier wird eine Variable `age` vom Typ `int` deklariert und gleichzeitig auf `24` initialisiert.

Da es sich um eine Variable handelt, können wir auch den Wert von Variablen ändern. Zum Beispiel:

````C#
int age = 24; 
... ... ...
age = 35;
````

Hier wird der Wert von `age` von 24 auf 35 geändert.

> In C# müssen Variablen deklariert werden, bevor sie benutzt werden können. Das heisst, der Name und der Typ der Variable müssen vor der
> Wertzuweisung bekannt sein. Aus diesem Grund ist C#
>
eine [statisch typisierte Sprache](https://stackoverflow.com/questions/1517582/what-is-the-difference-between-statically-typed-and-dynamically-typed-languages)
>
> Einmal deklariert, kann der Datentyp einer Variablen innerhalb seines _[Scopes](Scope.md)_ **nicht mehr geändert** werden. Ein Scope kann als
> Codeblock
> dargestellt
> werden, in welcher die Variable sichtbar oder verfügbar ist.

## Variablennamen

### Regeln für Variablennamen

Es gibt bestimmte Regeln, die wir bei der Benennung einer Variablen beachten müssen. Die Regeln für die Benennung einer Variable in C# sind:

1. Der Variablenname darf nur Buchstaben (Groß- und Kleinbuchstaben), Unterstriche (`_`) und Ziffern enthalten.
2. Der Variablenname muss entweder mit einem Buchstaben, einem Unterstrich oder dem Symbol `@` beginnen.
3. Ein Variablenname darf kein C#-Schlüsselwort sein. Zum Beispiel, `if`, `for`, `using` kann kein Variablenname sein.

| Variablenname | Bemerkung                                          |
|---------------|----------------------------------------------------|
| `name`        | gültig                                             |
| `subject2`    | gültig                                             |
| `_age`        | gültig                                             |
| `@break`      | gültig (Wird verwendet, wenn Name ein Keyword ist) |
| `2subject`    | ungültig (beginnt mit Ziffer)                      |
| `max_value`   | gültig                                             |
| `min width`   | ungültig (Leerzeichen)                             |

> C# ist Case-Sensitive, d.h. `age` und `Age` sind zwei verschieden Variablen.

### Konventionen für Variablennamen

1. Sinnvolle Variablennamen wählen, bspw. `name` und `age` anstatt `n` und `a`.
2. Verwende für die Benennung lokaler Variablen die **camelCase-Schreibweise**, z.B. `numberOfStudents`, `age`, etc.
3. Verwende für die Benennung _[öffentlicher](Zugriffsmodifikatoren.md#ffentlicher-zugriffsmodifikator)_ Variablen die **PascalCase-Schreibweise**,
   z.B. `FirstName`, `Price`, etc.
4. Verwende einen Unterstrich (`_`), gefolgt von der **camelCase-Schreibweise** für _[private](Zugriffsmodifikatoren.md#privater-zugriffsmodifikator)_
   Variablen,
   z.B. `_bankBalance`, `_emailAddress`, etc.