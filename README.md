# example-aspnet-treehouse-defense
#### Example console app written in C# focusing on objects ####

C# Objects

https://teamtreehouse.com/library/c-objects
 
![screenshot](https://github.com/sarn1/example-aspnet-treehouse-defense/blob/master/screenshot.png)
 
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

// auto-property (is a syntatic sugar): public MapLocation Location { get; private set; }



```
- Properties intentional looks like fields because they should be used like fields.  They should be used for simple things like setting and returning things.  Quick calculations that are supposed to be fast.
- More syntatic sugar:
```sql
public MapLocation Location {
    get
    {
        return _path.GetLocationAt(_pathStep);
    }
}

/*
 * The above can also be written as :
 * public MapLocation Location => _path.GetLocationAt(_pathStep);
 */
		 
public void Move()
{
	_pathStep += 1;
}

/*
 * The above can be written as :
 * public void Move => _pathStep += 1;
 */

 public void Scale(double factor)
{
    SideLength *= factor;
}
/*
 * The above can be written as :
 * public void Scale(double factor) => SideLength *= factor;
 */

```
- Setting a StartAt property to 10 without defining a constructor
```sql
public int StartAt { get; private set; } = 10;
```
- For-loop using a variable declared outside the loop so it can be used outside the loop's scope
```sql
int i = 0;
for (; i < invaders.Length; i++){}
```


Intermediate C#
https://teamtreehouse.com/library/intermediate-c

- Inheritance methods are done with `virtual` and `override` keywords.  See Invader.cs and SheidlededInvader.cs.
```csharp
class Bird
{
	public virtual void Move()
	{
		System.Console.WriteLine("Birds fly");
	}
}

class Penguin : Bird
{
	public override void Move()
	{
		System.Console.WriteLine("Penguins waddle");
	}
}

Bird bird = new Bird();
bird.Move();
Penguin penguin = new Penguin();
penguin.Move();
```
- Capitalized variables mean `protected`.
- _ prefixed variables mean `private`.
- All classes inherit from System.Object, then you override these using polymorphism.
- Learn about `GetHashCode()` and `Finalize()`.
- By putting abstract to a class definition, you no longer can create (instantiate) a concrete object of that class, but it onnly provides an abstract definition of what it means to be an invader.  See Invader.cs, BasicInvader.c, ShieldedInvader, SlowInvader.
- Interfact only defines the public interface for concrete classes that inherit from it.  Types abstraction in it's purest form.
- You create `interface` just like `abstract` classes.
- Interfaces don't have constructors or have implementations.  It only defines public that subclasses must have.  And Visual Studios can auto-generate.
- See IInvader.cs for the interface.  And see how its being used in the Invader.cs abstract class.
- Abstract class contain code that should be shared by concrete subclasses.
- C# doesn't allow multiple inheritance, but allows a class to inherit from multiple abstract classes.
- **Most developers prefer to use composition and implement the interface instead of inheriting from a base class.  This gives us the most flebility to alter the class in the future and removes the depedency on the base class.**
- Static class can't be inherited from any other class, nor can other class inherit from a static class.  You can't instantiate a static class.  System.Map is an example static map.
- See example of static class in Random.cs and how its re-integrated into ShieldedInvader.cs and Tower.cs.  It's not calling a global static random generator class.

## Notes Revisited
```csharp
// syntatic sugar for getter/setters

protected override int StepSize { get; } = 2;

public override int Health { get; protected set; } = 2;

 public bool IsNeutralized => Health <= 0;
```
- The app runs off `Game.cs` since it has `void main`
