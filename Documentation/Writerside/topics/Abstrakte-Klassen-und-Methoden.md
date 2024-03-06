# Abstraktion

In C# kann das `abstract`-Keyword für Klassen und Methoden verwendet werden:

- **Abstrakte Klasse**: Ist eine eingeschränkte Klasse, welche nicht dafür benutzt werden kann, um Objekte zu erstellen. Um auf sie zuzugreifen, muss
  sie von einer anderen Klasse geerbt werden.
- **Abstrakte Methoden**: Können nur in abstrakten Klassen benutzt werden und haben noch keinen Inhalt. Der Inhalt wird von der abgeleiteten Klasse
  bereitgestellt.

## Beispiel

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="abstract.cs" />
    </tab>
    <tab title="Output">
        The pig says: oink oink
        Zzz
    </tab>
</tabs>

Abstraktion kann auch mit [_C# Interfaces_](Interface.md) erreicht werden