using System;

namespace InterfaceExercise;

public class Truck : IVehicleExtended
{
    // Inherited properties
    public string Transmission { get; set; }
    public int Doors { get; set; }
    public bool HeatedSeats { get; set; }
    public int CupholderCount { get; set; }
    public string Name { get; set; }
    public int YearFounded { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"This {Name} truck has {Doors} doors and {CupholderCount} cup holders.");
        Console.WriteLine($"It {(HeatedSeats ? "does" : "does not")} have heated seats.");
        Console.WriteLine($"It {(FourWheelDrive ? "does" : "does not")} have 4WD with a {BedLengthFeet} foot bed length.");
    }

    // Class properties
    public bool FourWheelDrive { get; set; }
    public int BedLengthFeet { get; set; }
}
