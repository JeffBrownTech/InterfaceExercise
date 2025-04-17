using System;

namespace InterfaceExercise;

public interface IVehicle
{
    public string Transmission { get; set; }
    public int Doors { get; set; }
    public bool HeatedSeats { get; set; }
    public int CupholderCount { get; set; }

    public void DisplayDetails() {}
}
