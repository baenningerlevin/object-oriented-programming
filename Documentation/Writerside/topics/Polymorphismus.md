# Polymorphismus

Die Vererbung erlaubt es uns Methoden zu erben. Mit Polymorphismus können wir diese Methoden dazu bringen verschiedene Aufgaben zu machen.

Dafür benutzen wir die Keywords `virtual` (Basisklasse) und `override` (abgeleitete Klassen):

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="polymorphism.cs"/>
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            The animal makes a sound
            The pig says: oink oink
            The dog says: woof woof
        </code-block>
    </tab>
</tabs>

Würden wir das nicht machen, würden alle unsere Ausgaben `The animal makes a sound` sein, da sie nicht überschrieben werden.