using System;
public class LevelBase {

    public string StartMessage;
    public bool entranceOpen = true;

    public string[] environment = {"Cold", "Wet", "Dark"};

    public string[] objects = {"Rocks", "Ravine", "River", "Lava"};

    public void Enter (){
        Console.WriteLine(StartMessage);
    }

    public void Encounter (int i){
        switch (i)
        {
            case 0:
                Console.WriteLine("You've " traveled + " into " + objects[i]);
            break;

            case 1:
                Console.WriteLine("You've " + traveled + " into " + objects[i]);
            break;

            case 2:
                Console.WriteLine("You've " + traveled + " into " + objects[i]);
                Game.GameTimer();
                Random randomNumber = new Random();
                Game.UnderWater.Encounter(randomNumber.Next(0, Game.UnderWater.objects.LevelBase));
            break;

            case 3:
            //Danger kills us and ends the Game
                Console.WriteLine("You've " + traveled + " into " + objects[i]);
                if(objects[i] == "Shark") {
                    M16.SemiAutoFire();
                }
                Game.canPlay = false;
            break;

            default:
                Console.WriteLine("Your path is clear.");
            break;
        }
    }
}
        
        /*if(i < objects.Length) {
            Console.WriteLine("You've walked into " + objects[i]);
            if (objects[i] == "Lava"){
                Program.canPlay = false;
            }
        } else {
            Console.WriteLine("Your path is clear.");
        }*/
        
    }

public WeaponBase M16 = new


}

