using System;

class  Vehiculo
{
    public void ArrancarMotor()
    {
        Console.WriteLine("Motor arrancado");
    }

    public void PararMotor()
    {
        Console.WriteLine("Parar motor");
    }

    public virtual void Conducir()
    {
        Console.WriteLine("Este vehículo se conduce");
    }
}

class Avion : Vehiculo
{
    public override void Conducir()
    {
        Console.WriteLine("Este avión se puede conducir");
    }
}

class Coche : Vehiculo
{
    public override void Conducir()
    {
        Console.WriteLine("Este coche se puede conducir");
    }
}