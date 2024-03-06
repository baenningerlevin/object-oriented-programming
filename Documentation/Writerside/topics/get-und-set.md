# get und set

Auf `private` Variablen kann nur innerhalb der gleichen Klasse zugegriffen werden. Jedoch ist es manchmal notwendig auf diese Variablen 
zuzugreifen, dass kann mit **Properties** gemacht werden.

Ein Property ist eine Kombination aus einer Variable und einer Methode und es hat zwei Methoden: `get` und `set`.

````C#
class Person
{
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
}
````

Das Property `Name` ist mit der `name`-Eigenschaft verbunden. Es empfiehlt sich für das Property und die Eigenschaft denselben Namen zu verwenden.

Die `get`-Methode gibt den Wert der Variablen zurück.

Die `set`-Methode weist `value` der `name`-Variable zu. Das `value`-Keyword repräsentiert den Wert, den wir dem Property geben.

Nun können wir das `Name`-Property nutzen, um auf die private Eigenschaft zuzugreifen und um sie zu modifizieren.

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="getSet.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Liam
        </code-block>
    </tab>
</tabs>

## Shorthand

Damit wir nicht immer die gleichen Anweisungen für `get` und `set` schreiben müssen, gibt uns C# ein Shorthand. Der folgende Code macht genau das 
gleiche wie der obere, benutzt aber das Shorthand:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="getSetShorthand.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Liam
        </code-block>
    </tab>
</tabs>