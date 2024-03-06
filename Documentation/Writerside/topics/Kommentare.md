# Kommentare

Kommentare werden in einem Programm verwendet, um uns zu helfen, einen Teil des Codes zu verstehen. Sie sind für Menschen lesbare Wörter, die den Code
lesbar machen sollen. Kommentare werden vom Compiler vollständig ignoriert.

In C# gibt es 3 Arten von Kommentaren:

1. Einzeilige Kommentare (`//`)
2. Mehrzeilige Kommentare(`/* */`)
3. XML-Kommentare (`///`)

## Einzeilige Kommentare

Einzeilige Kommentare beginnen mit einem doppelten Schrägstrich `//`. Der Compiler ignoriert alles nach `//` bis zum Ende der Zeile. Zum Beispiel:

````C#
// Adding 5 and 7
int a = 5 + 7; 
````

Hier ist, `Adding 5 and 7` der Kommentar.

## Mehrzeilige Kommentare

Mehrzeilige Kommentare beginnen mit `/*` und enden mit `*/`. Mehrzeilige Kommentare können sich über mehrere Zeilen erstrecken.

````C#
/*
	This is a Hello World Program in C#.
	This program prints Hello World.
*/
using System;

namespace HelloWorld
{
	class Program
	{
		public static void Main(string[] args)
		{
			/* Prints Hello World     */
			Console.WriteLine("Hello World!");
		}
	}
}
````

## Kommentare zur XML-Dokumentation

Der XML-Dokumentationskommentar ist eine besondere Funktion in C#. Er beginnt mit einem dreifachen Schrägstrich /// und wird verwendet, um einen Teil
des Codes kategorisch zu beschreiben. Dies geschieht mithilfe von XML-Tags innerhalb eines Kommentars. Diese Kommentare werden dann verwendet, um eine
separate XML-Dokumentationsdatei zu erstellen. Mehr zu [XML](https://www.w3schools.com/xml/xml_whatis.asp)

````C#
/// <summary>
///  This is a hello world program.
/// </summary>

using System;

namespace HelloWorld
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
````

Das generierte XML-File wird folgenden Inhalt haben:

````XML
<?xml version="1.0"?>
<doc>
    <assembly>
        <name>HelloWorld</name>
    </assembly>
    <members>
    </members>
</doc>
````

Mehr zu [XML-Dokumentation Kommentare](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments)