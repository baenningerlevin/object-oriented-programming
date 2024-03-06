# Use-Case-Diagramm

Mit einem User-Case-Diagramm können wir anderen erklären, wie verschiedene Nutzer mit unserer App interagieren.

## Systeme

Ein System ist das, was wir entwickeln, bspw. eine Webseite, eine Softwarekomponente, eine Applikation, usw. In einem Use-Case-Diagramm ist das System
ein Rechteck mit dem Namen oben.

![system.png](system.png) { width="350" }

## Aktoren

Ein Aktor ist jemand oder etwas, dass unser System nutzt, um ein Ziel zu erreichen, bspw. eine Person, eine Organisation oder ein anderes System.
Wichtig ist, dass Aktoren ausserhalb des Systems platziert werden müssen. Aktoren werden als Strichmännchen dargestellt.

Zudem gibt es primäre Aktoren und sekundäre Aktoren. Primäre Aktoren initiieren die Nutzung unseres Systems, während sekundäre Aktoren reagieren.
Dabei sind primäre Aktoren auf der linken Seite und sekundäre Aktoren auf der rechten Seite unseres Systems.

![aktoren.png](aktoren.png) { width="350" thumbnail="true" }

## Use-Cases

Ein Use-Case repräsentiert eine Aktion, welche eine Art von Aufgabe in unserem System löst. Sie werden als Ovale dargestellt.

![use-cases.png](use-cases.png) { width="350" thumbnail="true" }

> Use-Cases werden vorzugweise nach Reihenfolge geordnet

## Beziehungen

### Assoziation

Um eine Beziehung bzw. Interaktion zwischen Aktor und Use-Case aufzuzeigen nutzen wir die Assoziation.

![assoziation-use-case.png](assoziation-use-case.png) { width="350" thumbnail="true" }

### Include

Die Include-Beziehung gibt an, dass wenn ein bestimmter Use-Case ausgeführt wird, dass dann sofort ein anderer Use-Case ausgeführt wird.

![include.png](include.png) { width="350" thumbnail="true" }

### Extend

Die Extend-Beziehung gibt an, dass wenn ein bestimmter Use-Case ausgeführt wird, dass ein anderer Use-Case ausgeführt werden kann, wenn gewisse
Kriterien stimmen.

![extend.png](extend.png) { width="350" thumbnail="true" }

### Generalization

Bei der Generalization-Beziehung können wir Use-Cases vererben.

![generalization.png](generalization.png) { width="350" thumbnail="true" }
