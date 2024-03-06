# Constructor

Ein **Constructor** ist eine spezielle Methode, die benutzt wird, um Objekte zu initialisieren. Der Vorteil des Constructors ist, dass er 
aufgerufen wird, wenn aus der Klasse ein Objekt erstellt wird. 

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="constructor.cs"/>
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Mustang
        </code-block>
    </tab>
</tabs>

> Der **Name des Constructors** muss mit dem **Namen der Klasse übereinstimmen**. Zudem kann er **keinen Rückgabetypen** haben

## Constructor Parameter

Constructors können ebenfalls Parameter haben, diese werden benutzt, um die Eigenschaften zu initialisieren.

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="constructorParams.cs"/>
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Red 1969 Mustang
        </code-block>
    </tab>
</tabs>

> Wie auch normale Methoden können Constructors überladen werden.