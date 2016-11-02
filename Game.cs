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
        Cave.Enter();
        while(Game.canPlay) {
            GameTimer();
            Play();
        }
        Console.WriteLine("You Died.");
        Console.WriteLine("Game Over");
    }

    public string gameState;


    private void Play (){        
        Console.WriteLine("Play commands: play, end, help");
        gameState = Console.ReadLine();
        
        if(gameState == "end") {
            Console.WriteLine("Game Over");
            Environment.Exit(0);
        }

        if(gameState == "help") {
            Console.WriteLine("What do you need help for? Id you can't play the game, you have issues.");
        }

        if(gameState != "help" || gameState != "play" || gameState !="end") {
            Console.WriteLine(gameState + " is not a valid option.");
            Play();
        }

        Random randomNum = new Random();
        Cave.Encounter(randomNum.Next(0, Cave.objects.Length), "walked");
    }

    public static void GameTimer () {
        System.Threading.Thread.Sleep(2000);
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