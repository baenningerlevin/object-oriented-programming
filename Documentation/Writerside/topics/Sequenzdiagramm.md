# Sequenzdiagramm

Ein Sequenzdiagramm zeigen wie Klassen miteinander interagieren, genauer gesagt bestimmen Sequenzdiagramme auch die Reihenfolge in welcher die
Aktionen ausgeführt werden.

## Aktoren

Genau wie in Use-Case-Diagrammen werden auch im Sequenzdiagramm Aktoren als Strichmännchen dargestellt.

## Objekte

Objekte sind die Dinge, die intern in einem System sind. Sie werden als Rechtecke dargestellt.

![aktoren-objekte.png](aktoren-objekte.png) { width="350" thumbnail="true" }

## Lifelines

Lifelines sind vertikale gestrichelte Linien, welche die Existenz eines Objektes oder eines Aktors über die Zeit zeigt.

![lifelines.png](lifelines.png) { width="350" thumbnail="true" }

## Interaktionen

### Message

Messages zeigen uns die Informationen an, die zwischen unseren Objekten gesendet werden.

### Return Message

Gibt ein Objekt einem anderen Objekt eine Message zurück, nennt man das Return Message und wird als gestrichelter Pfeil dargestellt.

### Alternative Frame

Mit einem Alternative Frame können wir Logik in unser Sequenzdiagramm einbauen.

### Activation Box

Mit einer Activation Box, sehen wir, wie lange ein Objekt benötigt wird bzw. genutzt wird.

## Beispiel

Hier sehen wir eine Interaktion, wo ein Aktor Geld abheben will:

![sequenzdiagramm-beispiel.png](sequenzdiagramm-beispiel.png)