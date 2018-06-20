using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
  public class Game : IGame
  {
    public Room CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }

    public void Reset()
    {
        
    }

    public void Play()
    {
      Console.Clear();
      Console.WriteLine("You land on the roof of the space ship you see a stairase leading down into the ship. There is a small plate with a button on it laying on the ground");
      
      var choice = Console.ReadLine();




      //get user input
      //input.split(" ")
      //switch input[0]
      //go
      //CurrentRoom.Go(input[1])
      //if succesfull CurrentRoom = Currentroom.(inputGo[1])
      //if(user input != null currentroom.go(input[1])
      //else cw "cant go there"
    }

    public void Setup()
    {
      Room room0 = new Room("Roof", "This is the roof");
      Room room1 = new Room("Room 1", "You go down the hatch into room 1");
      Room room2 = new Room("Room 2", "");
      Room room3 = new Room("Room 3", "");
      Room room4 = new Room("Room 4", "");
      room0.Items.Add(new Item("button", "a small button on a plate"));
      // Room room5 = new Room("Room 5", "");
      // Room room6 = new Room("Room 6", "");
      // Room room7 = new Room("Room 7", "");
      // Room room8 = new Room("Room 8", "");
      // Room room9 = new Room("Room 9", "");
      // Room room10 = new Room("Room 10", "");
      // Room room11 = new Room("Room 11", "");
      // Room room12 = new Room("Room 12", "");
      // Room room13 = new Room("Room 13", "");
      // Room room14 = new Room("Room 14", "");
      // Room room15 = new Room("Room 15", "");
      // Room room16 = new Room("Room 16", "");
      // Room room17 = new Room("Room 17", "");
      // Room room18 = new Room("Room 18", "");
      // Room room19 = new Room("Room 19", "");
      // Room room20 = new Room("Room 20", "");
      // Room room21 = new Room("Room 21", "");
      // Room room22 = new Room("Room 22", "");
      // Room room23 = new Room("Room 23", "");
      // Room room24 = new Room("Room 24", "");
      // Room room25 = new Room("Control Room", "");
        

        room0.Exits.Add("down", room1);
        room1.Exits.Add("up", room0);



        CurrentRoom = room0;
    }



    public void UseItem(string itemName)
    {
        
    }
  }
}