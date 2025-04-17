using System;

namespace InterfaceExercise;

public class SUV : IVehicleExtended
{
    // Inherited properties
    public string Transmission { get; set; }
    public int Doors { get; set; }
    public bool HeatedSeats { get; set; }
    public int CupholderCount { get; set; }
    public string Name { get; set; }
    public int YearFounded { get; set; }

    // Class properties
    public bool ThirdRowSeating { get; set; }
    public bool LuggageRack { get; set; }

    public void DisplayDetails() {
        Console.WriteLine($"This {Name} SUV has {Doors} doors and {CupholderCount} cup holders.");
        Console.WriteLine($"It {(HeatedSeats ? "does" : "does not")} have heated seats.");
        Console.WriteLine($"It {(ThirdRowSeating ? "has" : "does not have")} third row seating and {(LuggageRack ? "has" : "does not have")} a luggage rack.");
        
    }
}
