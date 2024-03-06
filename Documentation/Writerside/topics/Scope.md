# Scope

Ein Scope bezieht sich auf die Verfügbarkeit von Variablen in bestimmten Teilen des Codes.

In C# hat eine Variable drei Arten von Geltungsbereichen:

- Scope der Klassenebene
- Scope der Methodenebene
- Scope der Blockebene

## Klassenebene

Wenn wir eine Variable innerhalb einer Klasse deklarieren, können diese in der Klasse aufgerufen werden.

Sie sind uns auch bekannt als Eigenschaften und sie werden ausserhalb von Methoden, Constructors und Blocks deklariert. Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="classLevel.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Class Level
        </code-block>
    </tab>
</tabs>

Da `str` eine Variable der Klassenebene ist, können wir sie in der Methode aufrufen.

## Methodenebene

Wenn wir eine Variable innerhalb einer Methode deklarieren, kann auf diese nicht von ausserhalb der Methode zugegriffen werden. Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="methodLevel.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Error   CS0103     The name 'str' does not exist in the current context  
        </code-block>
    </tab>
</tabs>

`method2` kann nicht auf die Variable `str` zugreifen, da diese in einer anderen Methode deklariert wurde.

## Blockebene

Wenn wir eine Variables innerhalb eines Blocks ([_`for` Loop_](for-Loop.md), [_`while` Loop_](while-Loop.md), [_`if...else`_](if-else.md), etc.)
erstellt wird, kann auf diese auch nur in diesem Block zugegriffen werden. Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="blockLevel.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Error	 CS0103  The name 'i' does not exist in the current context
        </code-block>
    </tab>
</tabs>

Die Variable `i` ist eine Variable der Blockebene. Deshalb können wir nicht von ausserhalb dieses Blocks auf die Variable zugreifen.