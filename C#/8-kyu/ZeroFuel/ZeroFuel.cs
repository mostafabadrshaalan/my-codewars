using System;

public static class Kata
{
    public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
    {
        return (fuelLeft * mpg) >= distanceToPump;
    }
}