# Klassendiagramm

Klassendiagramme sind besonders nützlich zur Verdeutlichung der Struktur eines Systems, indem dessen Klassen, Attribute, Vorgänge und die Beziehungen
zwischen Objekten dargestellt werden.

## Klassen

Klassen werden als Rechteck dargestellt und in drei Teile aufgeteilt:

- **Oberer Teil**: Bezeichnung der Klasse
- **Mittelteil**: Enthält die Attribute der Klasse
- **Unterer Teil**: Enthält die Methoden der Klasse

### Zugriffsmodifikatoren

Bei den Attributen und Methoden muss man noch die Sichtbarkeit angeben, also `public`, `private`, etc. Dafür gibt es folgende Zeichen:

- **+** - Öffentlich
- **-** - Privat
- **#** - Protected

Es gibt noch weitere, diese sind jedoch eher ungewöhnlich.

### Datentypen

Für jedes Attribut und für jeden Rückgabewert einer Methode muss noch der Datentyp angegeben werden. Zudem kann in den Methoden noch die einzelnen
Parameter und deren Datentyp angegeben werden.

### Beispiel für eine Klasse

![classUML.png](classUML.png) { width="350" thumbnail="true" }

## Beziehungen

In einem Klassendiagramm gibt es verschiedene Arten von Beziehungen.

### Vererbung

Wenn eine Klasse Eigenschaften und Methoden von einer anderen Klasse erben soll, kann man das mit der Vererbung aufzeigen:

![vererbungUML.png](vererbungUML.png) { width="350" thumbnail="true" }

Hier erben die Klassen `Tortoise`, `Otter` und `SlowLoris` die Properties und Methoden von `Animal`.

#### Abstrakte Klasse

Um eine abstrakte Klasse zu erstellen, können wir den Namen der Klasse kursiv machen. Somit kann aus der Klasse kein Objekt erstellt werden.

### Assoziation

Eine Assoziation wird mit einer simplen Linie erstellt. Die Assoziation heisst aber nicht, dass die Klassen abhängig voneinander sind. Sie haben nur
eine Beziehung zwischen einander.

![assoziation.png](assoziation.png)

### Aggregation

### Komposition

