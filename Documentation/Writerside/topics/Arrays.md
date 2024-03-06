# Arrays

Ein Array ist eine Kollektion von ähnlichen Typen von Daten. Zum Beispiel, wenn wir das Alter von 5 Schülern erfassen sollen, müssen wir dafür
nicht fünf verschiedene Variablen erstellen, sondern können ganz einfach einen Array erstellen:

![array](array.jpg) { width="350" thumbnail="true" }

## Array deklarieren

Wir deklarieren einen Array wie folgt:

```C#
datatype[] arrayName;
```

- `dataType` - Datentyp für den Inhalt des Arrays
- `arrayName` - Der Identifier für den Array

Zum Beispiel:

````C#
int[] age;
````

### Speicherplatz vergeben

Um die Anzahl Elemente, die ein Array halten kann zu definieren. müssen wir dem Array Speicher geben:

````C#
// Array deklarieren
int[] age;

// Speicher vergeben
age = new int [5];
````

Jetzt kann der Array maximal fünf Elemente speichern.

> Wir können diese Speichervergabe auch auf einer Linie machen:
> ````C#
> int[] age = new int[5];
> ````

## Array initialisieren

Wir können den Array direkt bei der Deklaration initialisieren:

````C#
int[] numbers = [1, 2, 3, 4, 5]
````

Jetzt haben wir einen Array namens `numbers` erstellt, der die Werte `1`, `2`, `3`, `4` und `5` beinhaltet.

> Hier haben wir dem Array keinen Speicherplatz vergeben. In diesem Fall spezifiziert C# die Grösse automatisch

Zudem können wir Werte mithilfe des Indexes zuweisen. Der Index fängt bei `0` an, das erste Element des Arrays, danach ist der Index `1` das
zweite Element, etc.

````C#
// declare an array
int[] age = new int[5];

//initializing array
age[0] = 12;
age[1] = 4;
age[2] = 5;
... 
````

![Array Initialization](arrayInit.jpg) { width="350" thumbnail="true" }

> Ein Array Index startet immer mit `0`, d.h. das erste Element hat den Index `0`
>
> Der letzte Index ist immer `arr.length - 1`

## Auf Elemente zugreifen

Wir können auf die Elemente eines Arrays mit dem Index zugreifen:

````C#
array[2];
array[4];
````

## Elemente modifizieren

Um den Wert eines Elements in einem Array zu ändern, benutzen wir wieder den Index und geben ihm einen neuen Wert:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="arrayModify.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Old Value at index 0: 1
            New Value at index 0: 11
        </code-block>
    </tab>
</tabs>

## Über Arrays loopen

In C# gibt es zwei Wege, um über einen Array zu loopen, [_C# `for` Loop_](for-Loop.md) und [_C# `foreach` Loop_](foreach-Loop.md)

### for-Loop

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="arrayFor.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Element in index 0: 1
            Element in index 1: 2
            Element in index 2: 3
        </code-block>
    </tab>
</tabs>

### foreach-Loop

Hierfür verweise ich auf [_C# `foreach` Loop_](foreach-Loop.md)