# Primitive Datentypen

In C# werden Variablen grob in zwei Typen unterteilt: **Werttypen** und **Referenztypen**. In diesem Tutorial werden wir über primitive (einfache)
Datentypen sprechen, die eine Unterklasse von Werttypen sind.

## Boolean

- Der Datentyp **Boolean** hat zwei mögliche Werte: `true` oder `false`
- **Grösse**: 1 Bit
- **Standardwert**: `false`
- Boolesche Variablen werden im Allgemeinen zur Überprüfung von Bedingungen verwendet, z.B. in `if`-Anweisungen, Schleifen, etc.

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="boolean.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            True
        </code-block>
    </tab>
</tabs>

## Vorzeichenbehaftete Datentypen

Diese Datentypen enthalten ganzzahlige Werte (sowohl positive als auch negative). Von den insgesamt verfügbaren Bits wird ein Bit für das Vorzeichen
verwendet.

### sbyte

- **Grösse**: 8 Bit
- **Bereich**: -128 bis 127
- **Standardwert**: 0

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="sbyte.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            23
        </code-block>
    </tab>
</tabs>

> Wenn wir versuchen Werte **ausserhalb des Bereiches** des Datentyps zu benutzen, werden wir einen **Fehler** zurückbekommen

### short

- **Grösse**: 16 Bit
- **Bereich**: -32'768 bis 32'767
- **Standardwert**: 0

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="short.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            -1109
        </code-block>
    </tab>
</tabs>

### int

- **Grösse**: 32 Bit
- **Bereich**: -2'147'483'648 bis 2'147'483'647
- **Standardwert**: 0

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="int.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            51092
        </code-block>
    </tab>
</tabs>

### long

- **Grösse**: 64 Bit
- **Bereich**: -9'223'372'036'854'775'808 bis 9'223'372'036'854'775'807
- **Standardwert**: 0L

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="long.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            -7091821871
        </code-block>
    </tab>
</tabs>

## Datentypen ohne Vorzeichen

Diese Datentypen enthalten nur Werte, die gleich oder größer als 0 sind. Wir verwenden diese Datentypen im Allgemeinen zum Speichern von Werten, wenn
wir sicher sind, dass wir keine negativen Werte haben werden.

### byte

- **Grösse**: 8 Bit
- **Bereich**: 0 bis 255
- **Standardwert**: 0

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="byte.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            62
        </code-block>
    </tab>
</tabs>

### ushort

- **Grösse**: 16 Bit
- **Bereich**: 0 bis 65'535
- **Standardwert**: 0

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="ushort.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            42019
        </code-block>
    </tab>
</tabs>

### uint

- **Grösse**: 32 Bit
- **Bereich**: 0 bis 4.294.967.295
- **Standardwert**: 0

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="uint.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            1151092
        </code-block>
    </tab>
</tabs>

### ulong

- **Grösse**: 64 Bit
- **Bereich**: 0 bis 18.446.744.073.709.551.615
- **Standardwert**: 0L

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="ulong.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            17091821871
        </code-block>
    </tab>
</tabs>

## Fliesskommazahlen

Diese Datentypen enthalten Fliesskommazahlen, d.h. Zahlen mit Dezimalwerten. Zum Beispiel 12,36, -92,17, usw.

### float

- Gleitkommatyp mit einfacher Genauigkeit (6 bis 7 Nachkommastellen)
- **Grösse**: 32 Bit
- **Bereich**: 1,5 × 10<sup>-45</sup> bis 3,4 × 10<sup>38</sup>
- **Standardwert**: 0.0F

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="float.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            43.27
        </code-block>
    </tab>
</tabs>

### double

- Gleitkommatyp mit doppelter Genauigkeit (bis zu 15 Nachkommastellen)
- **Grösse**: 64 Bit
- **Bereich**: 5.0 × 10<sup>−324</sup> bis 1.7 × 10<sup>308</sup>
- **Standardwert**: 0.0D

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="double.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            -11092.53
        </code-block>
    </tab>
</tabs>

## Zeichen

- Repräsentiert ein 16 Bit Unicode Zeichen
- **Grösse**: 16 Bit
- **Bereich**: `U+0000 ('\u0000')` bis `U+FFFF ('\uffff')`
- **Standardwert**: '\0'

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="char.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            B
            x
        </code-block>
    </tab>
</tabs>

Der Unicode-Wert von `'B'` ist `'\u0042'`, daher wird beim Ausgeben von `ch1` `'B'` gedruckt.

## Zeichenkette

- Repräsentiert eine Folge von Zeichen (Text)
- Kein primitiver Datentyp, mehr dazu unter [_C# Strings_](Strings.md)
- **Grösse**: 16 Bit pro Zeichen

Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="string.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            C# Programming
        </code-block>
    </tab>
</tabs>

## Decimal

- Der Dezimaltyp hat eine höhere Genauigkeit und einen kleineren Bereich als die Fliesskommatypen (double und float). Er hat eine Genauigkeit von 28
  Nachkommastellen.
- **Grösse**: 128 Bit
- **Bereich**: 1.0 × 10<sup>-28</sup> to 7.9228 × 10<sup>28</sup>
- **Standardwert**: 0.0M

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="decimal.cs" />
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            53005.25
        </code-block>
    </tab>
</tabs>