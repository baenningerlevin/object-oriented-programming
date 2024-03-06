# Vererbung

In C# ist es möglich Eigenschaften und Methoden von einer anderen Klasse zu erben. Dabei gibt es zwei Kategorien:

- **Abgeleitete Klasse** - die Klasse, die die Member einer anderen Klasse erbt
- **Basisklasse** - die Klasse, von welcher geerbt wird

Um von einer Klasse zu erben, nutzen wir das `:`-Symbol.

Im unteren Beispiel erbt die `Car`-Klasse die Member der `Vehicle`-Klasse:

````C#
class Vehicle
{
  public string Brand;
  
  public void Honk()
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle  
{
  public string ModelName;

  public Car(string brand, string model) 
  {
    Brand = brand;
    ModelName = model;
  }
}

class Bicycle : Vehicle
{
  public string Color;
  
  public Bicycle(string brand, string color)
  {
    Brand = brand;
    Color = color
  }
}

class Program
{
  static void Main(string[] args)
  {
    Car myCar = new Car("BMW", "M4");
    Bicycle myBicycle = new Bicycle("Cube", "Blue");
  }
}
````

## Das sealed Keyword

Wenn wir nicht wollen, dass andere Klassen von einer Klasse erben, können wir das `sealed`-Keyword nutzen:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="sealed.cs"/>
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            'Car': cannot derive from sealed type 'Vehicle'
        </code-block>
    </tab>
</tabs>

## protected Members

Wie schon in [_C# Zugriffmodifikatoren_](Zugriffsmodifikatoren.md#gesch-tzter-zugriffsmodifikator) erwähnt, kann auf Member nur von ihren Klassen
und deren abgeleiteten Klassen zugegriffen werden.

## Das base Keyword

Mit dem `base`-Keyword können wir Methoden von der Basisklasse aufrufen. Zum Beispiel:

<tabs>
    <tab title="C#">
        <code-block lang="c#" src="base.cs"/>
    </tab>
    <tab title="Output">
        <code-block lang="bash">
            Animals eat food.
            Dogs eat Dog food.
        </code-block>
    </tab>
</tabs>

Mehr über `virtual` und `override` findest du hier: [_C# Polymorphismus_](Polymorphismus.md)