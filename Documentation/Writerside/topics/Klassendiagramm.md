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

![assoziation.png](assoziation.png) { width="350" thumbnail="true" }

### Aggregation

Die Aggregation ist eine spezielle Art von Assoziation. In dieser Relation kann ein Objekt Teil von einer anderen Klasse sein, muss aber nicht. Am
besten schauen wir uns dazu ien Beispiel an:

![aggregation.png](aggregation.png) { width="350" thumbnail="true" }

Hier sieht man gut, dass eine Schildkröte zu einer Gruppe gehören kann, jedoch kann eine Schildkröte auch ohne Probleme ohne Gruppe existieren.

### Komposition

Die Komposition ist exakt gleich wie die Aggregation, ausser dass hier das Objekt nicht ausserhalb der referenzierten Klasse existieren kann.

![](komposition.png) { width="350" thumbnail="true"}

In diesem Beispiel können die Lobby und die Toiletten nicht existieren, falls es kein Besucherzentrum gibt.

### Multiplicity

Mit Multiplicity können wir numerische Einschränkungen für unsere Beziehungen festlegen:

| Schreibweise | Beschreibung               |
|--------------|----------------------------|
| `0..1`       | Zero to one                |
| `n`          | Spezifische Zahl           |
| `0..*`       | Zero to many               |
| `1..*`       | One to many                |
| `m..n`       | Spezifischer Zahlenbereich |

![](multiplicity.png) { width="350" thumbnail="true" }

## Beispiel

![klassendiagramm_beispiel.png](klassendiagramm_beispiel.png) { width="500" thumbnail="true" }