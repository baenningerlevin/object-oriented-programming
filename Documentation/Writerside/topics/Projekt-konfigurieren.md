# Projekt konfigurieren

Zuerst erstellen wir mit der Vorlage **ASP.NET Core-Web-App (Model-View-Controller)** ein Projekt. Zuerst geben wir Namen, Speicherort, etc. ein. Die
restlichen Einstellungen belassen wir auf dem Standard.

> **Wichtig**: Wenn wir Authentifizierung in unserem Programm benötigen, können wir unter dem Dropdown **Authentifizierungstyp** den Punkt **Einzelne
Konten** auswählen

{ style="warning" }

## Pakete installieren

Wenn unser Projekt erfolgreich erstellt wurde, müssen wir noch einige Pakete herunterladen und installieren. Diese Pakete enthalten Tools,
Schnittstellen, Klassen und Methoden für die Datenbankanbindung und die Aufbereitung der Modelldaten für die View. Die Pakete können über <ui-path>
Extras | NuGet-Paket-Manager | Nuget-Pakete für Projektmappe verwalten</ui-path> heruntergeladen und installiert werden:

- Microsoft.EntityFrameWorkCore
- Microsoft.EntityFrameWorkCore.SqlServer
- Microsoft.EntityFrameWorkCore.Tools

Nun sind wir bereit unser erstes Modell zu erstellen.