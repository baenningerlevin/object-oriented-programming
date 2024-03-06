# UML

Bei UML (**Unified Modeling Language**) handelt es sich um eine Methode zur **visuellen Darstellung** der Architektur, des Designs und der
Implementierung
komplexer Software-Systeme. Beim Programmieren einer Anwendung mit tausenden von Zeilen an Code ist es schwierig, den Überblick über die Beziehungen
und Hierarchien innerhalb eines Software-Systems zu behalten. UML-Diagramme unterteilen dieses Software-System in Komponenten und Unterkomponenten.

UML ist eine **standardisierte Modellierungssprache**, die auf verschiedene Programmiersprachen und Entwicklungsprozesse anwendbar ist, weshalb die
meisten Software-Entwickler sie benutzen.

## Arten von UML-Diagrammen

Dem Laien mag es so vorkommen, als gäbe es eine unendliche Anzahl von UML-Diagrammen. Tatsächlich aber werden in den UML Standards **13 Typen von
Diagrammen** identifiziert und in **zwei Gruppen** unterteilt, die im Folgenden definiert werden.

### Strukturelle UML-Diagramme

Strukturelle UML-Diagramme zeigen, wie der Name schon sagt, wie das System strukturiert ist, einschließlich der Klassen, Objekte, Pakete, Komponenten
usw. im System und der Beziehungen zwischen diesen Elementen.

#### Klassendiagramme

Da Software meist auf objektorientierter Programmierung basiert, bei der Entwickelnde Arten von Funktionen definieren, die verwendet werden können,
sind Klassendiagramme die am häufigsten verwendete Art von UML-Diagrammen. Ein Klassendiagramm zeigt die statische Struktur eines Systems,
einschließlich der Klassen, ihrer Attribute und Verhaltensweisen sowie der Beziehungen zwischen den einzelnen Klassen.

![classdiagram.png](classdiagram.png) { width="350" thumbnail="true" }

Mehr zu [_UML - Klassendiagrammen_](Klassendiagramm.md) findest du hier.

#### Komponentendiagramm

Ein Komponentendiagramm ist im Wesentlichen eine spezialisiertere Version eines Klassendiagramms. Für beide gelten die gleichen Notationsregeln. Ein
Komponentendiagramm schlüsselt ein komplexes System in kleinere Komponenten auf und veranschaulicht die Beziehungen zwischen diesen Komponenten.

![component.png](component.png) { width="350" thumbnail="true" }

Mehr zu [**UML - Komponentendiagramme**](https://www.lucidchart.com/pages/de/uml-komponentendiagramm) findest du hier.

#### Verteilungsdiagramm

Verteilungsdiagramme zeigen, wie Software auf Hardware-Komponenten in einem System verteilt wird. Diese Diagramme sind vor allem für Systemtechniker
von großem Nutzen und zeigen üblicherweise Leistung, Skalierbarkeit, Wartungsfreundlichkeit und Portabilität. Wenn Hardware-Komponenten im Verhältnis
zueinander dargestellt werden, ist es einfacher, den Überblick über Ihr gesamtes Hardware-Gefüge zu behalten und sicherzustellen, dass bei einer
Verteilung alle Elemente berücksichtigt werden.

![verteilungsdiagramm.png](verteilungsdiagramm.png) { width="350" thumbnail="true" }

Mehr zu [**UML - Verteilungsdiagrammen**](https://www.lucidchart.com/pages/de/tutorial-fur-verteilungsdiagramme) findest du hier.

#### Kompositionsstrukturdiagramm

Bei diesen Diagrammen handelt es sich im Wesentlichen um die Entwürfe für die interne Struktur eines Klassifizierers. Sie können zudem verwendet
werden, um das Verhalten einer Kollaboration oder die Interaktionen des Klassifizierers mit seiner Umgebung durch Ports darzustellen. Sie können die
internen Komponenten jeglicher Hardware leicht veranschaulichen, um ein besseres Verständnis der inneren Funktionsweise zu ermöglichen.

![composite.png](composite.png) { width="350" thumbnail="true" }

Mehr zu [**UML - Kompositionsstrukturdiagrammen**](https://www.lucidchart.com/pages/uml-composite-structure-diagram?usecase=uml) findest du hier.

#### Objektdiagramm

Objektdiagramme zeigen Beispiele für Datenstrukturen zu einem bestimmten Zeitpunkt. Sie können ein Klassendiagramm zur Darstellung einer Struktur
verwenden und dann Objektdiagramme als Testfälle einsetzen, um die Vollständigkeit Ihres Klassendiagramms zu überprüfen. Alternativ können Sie ein
Objektdiagramm erstellen, um Informationen über Modellelemente und ihre Verbindungen zu erhalten.

![objekt.png](objekt.png) { width="350" thumbnail="true" }

Mehr zu [**UML - Objektdiagrammen**](https://www.lucidchart.com/pages/de/objektdiagramm-uml) findest du hier.

#### Paketdiagramm

Mit Paketdiagrammen lassen sich Abhängigkeiten zwischen verschiedenen Paketen in einem System darstellen. Ein Paket, das als Dateiordner dargestellt
wird, organisiert Modellelemente wie Anwendungsfälle oder Klassen in Gruppen.

![paket.png](paket.png){ width="350" thumbnail="true" }

Mehr zu [**UML - Paketdiagrammen**](https://www.lucidchart.com/pages/uml-package-diagram?usecase=uml) findest du hier.

### Verhaltensbasierte UML-Diagrammen

Diese UML-Diagramme veranschaulichen, wie sich das System verhält und mit sich selbst sowie mit Nutzende, anderen Systemen und Entitäten interagiert.

#### Use-Case-Diagramm

In Use-Case-Diagrammen wird modelliert, wie Benutzende, die als Strichmännchen dargestellt und als „Akteure“ bezeichnet werden, mit dem System
interagieren. Diese Art von UML-Diagramm sollte einen groben Überblick über die Beziehungen zwischen Akteuren und Systemen geben und kann daher ein
hervorragendes Mittel sein, um Personen ohne technischen Hintergrund Ihr System zu erläutern.

![use-case.png](use-case.png) { width="350" thumbnail="true" }

Mehr zu [_UML - Paketdiagrammen_](Use-Case-Diagramm.md) findest du hier.

#### Sequenzdiagramm

Ein Sequenzdiagramm, manchmal auch als Ereignisdiagramm oder Ereignisszenario bezeichnet, zeigt die Reihenfolge, in der Objekte miteinander
interagieren. Auf diese Weise können Sie einfache Laufzeitszenarien visuell darstellen.

![sequenz.png](sequenz.png) { width="350" thumbnail="true" }

Mehr zu [_UML - Sequenzdiagrammen_](Sequenzdiagramm.md) findest du hier.

#### Zeitverlaufsdiagramm

Ein Zeitverlaufsdiagramm wird oft als umgekehrtes Sequenzdiagramm beschrieben und zeigt, wie Objekte in einem bestimmten Zeitrahmen miteinander
interagieren. Mithilfe dieser Diagramme können Sie feststellen, wie lange die einzelnen Schritte eines Prozesses dauern, und Bereiche mit
Verbesserungspotenzial finden.

![timing2.png](timing2.png) { width="350" thumbnail="true" }

Mehr zu [**UML - Zeitverlaufsdiagrammen**](https://www.lucidchart.com/pages/uml-timing-diagram) findest du hier.

#### Interaktionsübersichtdiagramm

Dieses Diagramm gibt einen Überblick über den Kontrollfluss zwischen miteinander interagierenden Knoten. Dazu gehören Anfangs-, Flussabschluss-,
Aktivitätsabschluss-, Entscheidungs-, Zusammenführungs-, Verzweigungs- und Verbindungsknoten.

![interaktion.png](interaktion.png) { width="350" thumbnail="true" }

Mehr zu [**UML - Interaktionsübersichtsdiagrammen**](https://www.lucidchart.com/pages/uml-interaction-diagram?usecase=uml) findest du hier.

#### Kommunikationsdiagramme

Kommunikationsdiagramme, die früher als Kollaborationsdiagramme bezeichnet wurden, zeigen, wie Objekte zueinander in Beziehung stehen. Sie modellieren
die Art und Weise, wie Objekte innerhalb eines architektonischen Entwurfs eines Systems durch Nachrichten assoziiert und miteinander verbunden werden.
Sie können zudem alternative Szenarien innerhalb von Anwendungsfällen oder Operationen aufzeigen, welche die Zusammenarbeit verschiedener Objekte und
Interaktionen erfordern.

![kommunikation.png](kommunikation.png) { width="350" thumbnail="true" }

Mehr zu [**UML - Kommunikationsdiagrammen**](https://www.lucidchart.com/pages/uml-communication-diagram) findest du hier.

#### Zustandsdiagramm

In Zustandsdiagrammen werden, einfach ausgedrückt, Zustände und Übergänge abgebildet. Ein Zustand bezieht sich auf die verschiedenen Kombinationen von
Informationen, die ein Objekt enthalten kann. In diesem UML-Diagramm können alle möglichen Zustände und die Art und Weise, wie das Objekt von einem
Zustand in den nächsten übergeht, dargestellt werden.

![zustand.png](zustand.png) { width="350" thumbnail="true" }

Mehr zu [**UML - Zustandsdiagrammen**](https://www.lucidchart.com/pages/de/maschinenzustandsdiagramm) findest du hier.

#### Aktivitätsdiagramm

Aktivitätsdiagramme visualisieren die Schritte, die in einem Anwendungsfall ausgeführt werden. Die Aktivitäten können sequentiell, verzweigt oder
gleichzeitig ablaufend sein. Diese UML-Diagramme werden verwendet, um das dynamische Verhalten eines Systems darzustellen, können aber auch bei der
Geschäftsprozessmodellierung von Nutzende sein.

![aktivität.png](aktivität.png) { width="350" thumbnail="true" }

Mehr zu [**UML - Aktivitätsdiagrammen**](https://www.lucidchart.com/pages/de/uml-aktivitatsdiagramme) findest du hier.