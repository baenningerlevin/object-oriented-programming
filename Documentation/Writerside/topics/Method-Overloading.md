# Method Overloading

In C# kann es zwei oder mehr Methoden in einer Klasse mit dem gleichen Namen, aber unterschiedlicher Anzahl, Typ und Reihenfolge der Parameter geben,
dies wird als Methodenüberladung bezeichnet. Zum Beispiel:

```C#
void display() { ... }
void display(int a) { ... }
float display(double a) { ... }
float display(int a, float b) { ... }
```

Hier wird die Methode `Display()` überladen. Diese Methoden haben den gleichen Namen, akzeptieren aber unterschiedliche Argumente.

> Die Rückgabetypen der oben genannten Methoden sind nicht identisch. Dies liegt daran, dass das Überladen von Methoden nicht mit Rückgabetypen
> verbunden ist. Überladene Methoden können den gleichen oder einen anderen Rückgabetyp haben, aber sie müssen unterschiedliche Parameter haben.

## Anzahl der Parameter ändern

Wir können eine Methode überladen, falls die Anzahl der Parameter verschieden sind:

````C#
void display(int a) {
  ...
} 
...
void display(int a, int b) {
  ...
} 
````

## Datentyp ändern

Wir können eine Methode überladen, falls die Datentypen verschieden sind:

````C#
void display(int a) {
  ...
} 
...
void display(string b) {
  ...
} 
````

## Reihenfolge der Parameter ändern

Eine weitere Möglichkeit eine Methode zu überladen, ist es die Reihenfolge der Parameter zu ändern:

````C#
void display(int a, string b) {
  ...
} 
...
void display(string b, int a) {
  ...
}
````

