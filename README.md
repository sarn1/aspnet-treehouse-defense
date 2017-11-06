# example-aspnet-treehouse-defense
#### Example console app written in C# focusing on objects ####

C# Objects

https://teamtreehouse.com/library/c-objects
 
- Convention is to name classes with upper case first letter, so you can name the object by their type (class).
 ```csharp
 Tower tower = new Tower();  
 ```
- Object is an instance of a class.
- Fields are private by default.
- Constructor methods are name after the class its in (Map.cs).
- Public instance variables are cap (Map.cs).
- `readonly` ensures that a field doesn't get changed after the object is constructed (Map.cs).
- Constructor method can't return anything.
- Overloading example...
```csharp
public int DistanceTo(int x, int y)
{
    //cartesian formula
    int xDiff = X - x;
    int yDiff = Y - y;

    int xDiffSq = xDiff* xDiff;
    int yDiffSq = yDiff* yDiff;

    return (int) System.Math.Sqrt(xDiffSq+ yDiffSq);
}

//overloading
public int DistanceTo(Point point)
{
    //cartesian formula
    int xDiff = X - point.X;
    int yDiff = Y - point.Y;

    int xDiffSq = xDiff * xDiff;
    int yDiffSq = yDiff * yDiff;

    return (int)System.Math.Sqrt(xDiffSq + yDiffSq);
}
```
- MapLocation is a subclass and inherits from Point (MapLocation.cs).
- The requirements of Point (the 2 parameter constructor) must be satisfied since it first calls the point class.
- Base class = Parent Class / Super Class.
- Sub class = Child Class / Derived Class.
- You can use `is` to see if an object is of a specific type.
```csharp
Point x = new MapLocation(4,2);
Console.WriteLine(x is MapLocation);	//return true
```
- Interesting use of try/catch and throwing exceptions...
```csharp
try {
    if (value < 0 || value > 20)
    {
        throw new System.Exception("Invalid");
    }
} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}
```
- No base since this is the default constructor and it implies that the base constructor is called (Exceptions.cs).
- The order of the catches matter, the more specific ones need to be at the top, also child exceptions need to be before the generic `System.Exception`.
```csharp
//the same
string[] a = new string[]{"a","b","c"};
string[] a = new []{"a","b","c"};
string[] a = {"a","b","c"};
```
- Instead of using traditional getters & setters, you can use "properties".
```csharp

public MapLocation GetLocation ()
{
    return _location;
}

public void SetLocation(MapLocation value)
{
    _location = value;
}

// you can do this instead

public MapLocation Location 
{
	get
	{
		return _location;
	}
	set
	{
		_location = value;
	}
}

// x.Location = 5 will call the properties

```
