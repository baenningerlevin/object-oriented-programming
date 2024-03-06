# ASP.NET Core MVC

ASP.NET Core MVC ist ein umfangreiches Framework zum Erstellen von Web-Apps und APIs mithilfe des Model-View-Controller-Entwurfsmusters.

## Model - View - Controller

MVC ist ein Muster zur Unterteilung der Software in die drei Komponenten Datenmodell (Model), Präsentation (View) und Programmsteuerung (Controller)
und wird meistens dann eingesetzt, wenn ein Programm mit Benutzeroberfläche gefordert wird.

Ziel:

- Flexibler Programmentwurf - späte Änderungen möglich und leicht umzusetzen
- Wiederverwendbarkeit steigern
- Simultanes Arbeiten möglich

### Model (Modell)

- Repräsentiert die Daten und die Geschäftslogik
- Verantwortlich für Zugriff auf Datenbank
- Definiert die Validierungsregeln für die Datenbank und die Anwendung

![model.png](model.png) { width="150" }

### Controller (Steuerung)

- Vermittler zwischen Model und View
- Verarbeitet Benutzereingaben
- Steuert Datenfluss zu Model und View

![controller.png](controller.png) { width="150" }

### View (Ansicht)

- Benutzeroberfläche
- Präsentiert Daten dem Benutzer
- Abhängig vom Model

![view.png](view.png) { width="150" }

### Interaktionen im MVC-Pattern

* Der Benutzer interagiert mit der View (z.B. durch Klicken auf einen Button) oder dem Controller (Aufruf einer URL)
* Die View sendet die Benutzeranforderung an den Controller.
* Der Controller interpretiert die Anfrage und interagiert mit dem Model, um notwendige Daten zu abzurufen oder zu aktualisieren.
* Das Model interagiert mit der Datenbank, um Daten abzufragen oder zu speichern.
* Das Model sendet die Daten zurück an den Controller.
* Der Controller gibt die Daten an die View weiter, um sie dem Benutzer darzustellen.

![mvc-interactions.png](mvc-interactions.png) { width="400" }