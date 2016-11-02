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
                Console.WriteLine();
            default:
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

}