# Interface

Ein Interface ist ein anderer Weg Abstraktion in C# zu erzielen. Ein Interface ist eine abstrakte Klasse, welche nur abstrakte Methoden und Properties
beinhält.

Um auf die Methoden und Properties eines Interfaces zuzugreifen, muss das Interface von einer anderen Klasse implementiert werden. Dafür nutzen wir
wie bei der Vererbung das `:`-Symbol.

## Beispiel

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="interface.cs" /> 
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            The pig says: oink oink
        </code-block>
    </tab>
</tabs>

> **Bemerkungen zu Interfaces**
> - Genau wie abstrakte Klassen kann man mit Interfaces **keine Objekte erstellen**
> - Bei der Implementation müssen **alle Methoden überschrieben** werden
> - Ein Interface kann **keinen Konstruktor** haben
> - Im Gegensatz zur Vererbung kann man mit Interfaces die sogenannte **_Multiple Inheritance_** erreichen, da man **mehrere Interfaces implementieren
    ** kann