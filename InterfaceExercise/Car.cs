using System;

namespace InterfaceExercise;

public class Car : IVehicleExtended
{
    // Inherited members
    public string Transmission { get; set; }
    public int Doors { get; set; }
    public bool HeatedSeats { get; set; }
    public int CupholderCount { get; set; }
    public string Name { get; set; }
    public int YearFounded { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"This {Name} car has {Doors} doors and {CupholderCount} cup holders.");
        Console.WriteLine($"It {(HeatedSeats ? "does" : "does not")} have heated seats.");
        Console.WriteLine($"It's body style is {BodyStyle} and {(HasTrunk ? "does" : "does not")} have a trunk.");
    }

    // Class members
    public bool HasTrunk { get; set; }
    public string BodyStyle { get; set; }
}
