# Objektorientierte Programmierung

Objektorientierte Programmierung (OOP) ist ein Modell der Computerprogrammierung, bei dem das Softwaredesign auf Daten oder Objekten basiert und nicht auf Funktionen und Logik. Ein Objekt kann als ein Datenfeld definiert werden, das eindeutige Attribute und Verhaltensweisen aufweist.

## Begriffe

### Klasse

User-definierter Datentyp, die als Vorlage für individuelle Objekte, Attribute und Methoden dienen.

### Attribut

Werden in der Klassenvorlage definiert und stellen den Zustand eines Objekts dar.

### Methode

Funktionen, die innerhalb einer Klasse definiert sind und das Verhalten eines Objekts beschreiben

### Objekt

Instanz einer Klasse, die mit speziell definierten Daten erstellt werden.

## Beispiel

````C#
class Car
{
    string Brand;
    string Model;
    
    void DisplayCarInfo() 
    {
        Console.WriteLine($"Marke: {Brand}, Model: {Model}");
    }
}

class Program 
{
    static void Main(string[] args)
    {
        Car myCar = new Car;
        myCar.Brand = "Audi";
        myCar.Model = "R8";
        myCar.DisplayCarInfo();
    }
}
````

Hier ist die Klasse `Car`, die Attribute davon sind `Brand` und `Model`. Die Klasse hat zusätzlich noch die Methode `DisplayCarInfo()`. Aus dieser 
Klasse wird das Objekt `myCar` erstellt.