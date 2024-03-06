# Konfiguration - SQL Server

<procedure>
    <step>SQL Server installieren, Server anmachen</step>
    <step>Über <ui-path>Ansicht | Server-Explorer</ui-path> dem Server-Explorer öffnen</step>
    <step>Rechtsklick auf <ui-path>Datenverbindungen</ui-path> und danach <ui-path>Neue SQL Server-Datenbank erstellen</ui-path> auswählen</step>
    <step>Servername gemäss lokalem SQL-Server eintragen, z.B. <ui-path>BUZ0WOP01481\SQLEXPRESS</ui-path></step>
    <step>Die Checkbox <ui-path>Serverzertifikat vertrauen</ui-path> auswählen</step>
    <step>Datenbanknamen eingeben</step>
    <step>Auf die neue Datenverbindung im <ui-path>Server-Explorer</ui-path> rechtsklick machen und auf <ui-path>Eigenschaften</ui-path> gehen</step>
    <step>Die <ui-path>Verbindungszeichenfolge</ui-path> kopieren</step>
    <step>In <ui-path>appsettings.json</ui-path> den Wert der `DefaultConnection` mit dem kopierten String ersetzen</step>
</procedure>