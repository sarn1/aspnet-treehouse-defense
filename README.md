# example-aspnet-treehouse-defense
#### Example console app written in C# focusing on objects ####

C# Objects

https://teamtreehouse.com/library/c-objects
 
 ```csharp
 Tower tower = new Tower();  
 ```
- convention is to name classes with upper case first letter, so you can name the object by their type (class)
- object is an instance of a class
- fields are private by default
- constructor methods are name after the class its in (Map.cs)
- public instance variables are cap (Map.cs)
- readonly ensures that a field doesn't get changed after the object is constructed (Map.cs)
- constructor method can't return anything
- overloading example
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
- 