# if...else

## if-Statement

Das Testen einer Bedingung ist beim Programmieren unvermeidlich. Wir werden oft mit Situationen konfrontiert, in denen wir Bedingungen testen müssen (
ob sie `true` oder `false` sind), um den Ablauf des Programms zu steuern. Diese Bedingungen können von den Eingaben des Benutzers, dem Zeitfaktor, der
aktuellen Umgebung, in der das Programm läuft, usw. beeinflusst werden.

Das `if`-Statement führt einen Codeblock aus, wenn die gegebene Bedingung wahr ist. Die Syntax sieht wie folgt aus:

````C#
if (boolean-expression)
{
	// statements executed if boolean-expression is true
}
````

- Die `boolean-expression` gibt entweder `true` oder `false` zurück.
- Wenn sie `true` zurückgibt, werden die Anweisungen in den `{...}` ausgeführt.
- Wenn sie `false` zurückgibt, werden die Anweisungen ignoriert.

**Zum Beispiel:**

````C#
if (number < 5)
{
	number += 5;
}
````

Hier wird die Anweisung `number += 5` nur ausgeführt, wenn `number` kleiner als `5` ist.

## if...else-Statement

Ein `if`-Statement kann in C# optional auch ein `else`-Statement haben. Der Code im `else`-Statement wird dann ausgeführt, wenn die Bedingung `false`
ist.

Die Syntax sieht folgendermassen aus:

````C#
if (boolean-expression)
{
	// statements executed if boolean-expression is true
}
else
{
	// statements executed if boolean-expression is false
}
````

**Zum Beispiel:**

````C#
if (number < 5)
{
	number += 5;
}
else
{
	number -= 5;
}
````

Hier wird die Anweisung `number += 5` nur dann ausgeführt, wenn der Wert von `number` kleiner als `5` ist.

Die Anweisung `number -= 5` wird
ausgeführt, wenn der Wert von `number` grösser oder gleich `5` ist.

## if...else if-Statement

Wenn wir etwas auf mehrere Konditionen testen möchten, können wir auch sogenannte `else if`-Statements machen. Die Syntax sieht so aus:

````C#
if (boolean-expression-1)
{
	// statements executed if boolean-expression-1 is true
}
else if (boolean-expression-2)
{
	// statements executed if boolean-expression-2 is true
}
else if (boolean-expression-3)
{
	// statements executed if boolean-expression-3 is true
}
.
.
.
else
{
	// statements executed if all above expressions are false
}
````

Dabei wird das if...else if-Statement von **oben** nach **unten** ausgeführt. Sobald eine Bedingung wahr ist, wird der darin enthaltene Code
ausgeführt. Danach springt der Compiler aus dem `if...else if`-Block heraus.