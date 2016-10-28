using System;
public class Game {

    public Game () {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo.";
        Cave.StartMessage = "You have entered a cave.";
    }

    public void Start (){
        Console.WriteLine("Please type your name:");
        name = Console.ReadLine();
        Console.WriteLine("Your player name is " + name);
        Walk();
    }

    private void Walk (){
        Random randomNum= new Random();
        Cave.Enter();
        Cave.Encounter(randomNum.Next (0, Cave.objects.Length+1));
    }
    //Game Levels
    private LevelBase Cave = new LevelBase();
    //Game PowerUps
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();
    
    //Game Weapons    
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();
    private WeaponBase Knife = new WeaponBase();

    public string name;
    private int score;
}