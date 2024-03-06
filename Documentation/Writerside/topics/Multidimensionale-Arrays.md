# Multidimensionale Arrays

In multidimensionalen Arrays ist jedes Element eines Arrays ebenfalls ein Array. Zum Beispiel:

````C#
int[ , ] x = { { 1, 2 ,3 }, { 3, 4, 5 } };
````

In diesem Beispiel ist `x` ein multidimensionaler Array mit zwei Elementen: `{1, 2, 3}` und `{3, 4, 5}`. Davon ist jedes Element ein Array mit
drei Elementen.

## Zweidimensionaler Array - Deklaration

Ein zweidimensionaler Array wird wie folgt deklariert:

````C#
int[ , ] x = new int [2, 3];
````

`x` ist ein zweidimensionaler Array mit **zwei Elementen**. Davon ist jedes Element ebenfalls ein Array mit **drei Elementen**.

Alles in allem kann der Array **sechs Elemente** speichern **(2 * 3**).

## Zweidimensionaler Array - Initialisierung

Wir können den Array direkt während der Deklaration initialisieren. Zum Beispiel:

````C#
int[ , ] x = { { 1, 2 ,3}, { 3, 4, 5 } };
````

Wir können aber auch die Anzahl Reihen und Spalten während der Initialisierung spezifizieren:

````C#
int [ , ] x = new int[2, 3]{ {1, 2, 3}, {3, 4, 5} };
````

## Zweidimensionaler Array - Zugriff

Wir nutzen einmal den Index für den Äusseren Array und einmal den Index für das Element in diesem Index. Zum Beispiel:

````C#
int[ , ] x = { { 1, 2 ,3}, { 3, 4, 5 } };

x[0, 0];  // returns 1
x[1, 2];  // returns 5
x[0, 2];  // returns 3
````

## Zweidimensionaler Array - Schleife

Um über einen zweidimensionalen Array zu loopen, brauchen wir eine verschachtelte Schleife:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="twoDimensionalArrayLoop.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Row 0: 2 3 9
            Row 1: 4 5 9
        </code-block>
    </tab>
</tabs>

Das Loopen sieht bei einem zweidimensionalen Array ein wenig anders aus. Hier benutzen wir die Methode `GetLength` anstatt das Property `Length`:

- numbers.GetLength(0) - gibt uns die Anzahl Spalten in einem 2D Array zurück
- numbers.GetLength(1) - gibt und die Anzahl Elemente in einer Spalte zurück

> Natürlich können wir auch dreidimensionale Arrays erstellen. Dabei ist ein 3D Array ein Array, welcher mehrere zweidimensionale Arrays als
> Elemente hat. Zum Beispiel:
> ````C#
> int[ , , ] numbers = { { { 1, 3, 5 }, { 2, 4, 6 } }, { { 2, 4, 9 }, { 5, 7, 11 } } };
> ````