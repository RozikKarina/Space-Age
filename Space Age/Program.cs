using System;

public class SpaceAge
{
    private const double EARTH_YEAR_IN_SECONDS = 31557600.0;
    private readonly double _seconds;

    // Орбітальні періоди планет у порівнянні з роком на Землі
    private const double MERCURY_ORBITAL_PERIOD = 0.2408467;
    private const double VENUS_ORBITAL_PERIOD = 0.61519726;
    private const double EARTH_ORBITAL_PERIOD = 1.0;
    private const double MARS_ORBITAL_PERIOD = 1.8808158;
    private const double JUPITER_ORBITAL_PERIOD = 11.862615;
    private const double SATURN_ORBITAL_PERIOD = 29.447498;
    private const double URANUS_ORBITAL_PERIOD = 84.016846;
    private const double NEPTUNE_ORBITAL_PERIOD = 164.79132;

    // Конструктор, який приймає вік у секундах
    public SpaceAge(double seconds)
    {
        _seconds = seconds;
    }

    // Метод для обчислення віку на Землі
    public double OnEarth()
    {
        return _seconds / (EARTH_YEAR_IN_SECONDS * EARTH_ORBITAL_PERIOD);
    }

    // Метод для обчислення віку на Меркурії
    public double OnMercury()
    {
        return _seconds / (EARTH_YEAR_IN_SECONDS * MERCURY_ORBITAL_PERIOD);
    }

    // Метод для обчислення віку на Венері
    public double OnVenus()
    {
        return _seconds / (EARTH_YEAR_IN_SECONDS * VENUS_ORBITAL_PERIOD);
    }

    // Метод для обчислення віку на Марсі
    public double OnMars()
    {
        return _seconds / (EARTH_YEAR_IN_SECONDS * MARS_ORBITAL_PERIOD);
    }

    // Метод для обчислення віку на Юпітері
    public double OnJupiter()
    {
        return _seconds / (EARTH_YEAR_IN_SECONDS * JUPITER_ORBITAL_PERIOD);
    }

    // Метод для обчислення віку на Сатурні
    public double OnSaturn()
    {
        return _seconds / (EARTH_YEAR_IN_SECONDS * SATURN_ORBITAL_PERIOD);
    }

    // Метод для обчислення віку на Урані
    public double OnUranus()
    {
        return _seconds / (EARTH_YEAR_IN_SECONDS * URANUS_ORBITAL_PERIOD);
    }

    // Метод для обчислення віку на Нептуні
    public double OnNeptune()
    {
        return _seconds / (EARTH_YEAR_IN_SECONDS * NEPTUNE_ORBITAL_PERIOD);
    }
}