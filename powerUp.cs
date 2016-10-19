using System;


//Class is similar to object in javascript
public class PowerUp{
    public int power = 10;
    //float is a point value
    public float duration = 2;

    public void runPowerUp () {
        //consol.writeLine is similar to console.log . Cannot console.writeLine without using system.
        Console.WriteLine("Power up ran");
    }

    public void RechargePowerUP (int _power) {
        power += _power;
        Console.WriteLine("Recharged PowerUp to " + power);
    }
}