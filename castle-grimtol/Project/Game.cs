using System;
using System.Collections.Generic;
using CastleGrimtol.Project;

namespace CastleGrimtol.Project
{
  public class Game : IGame
  {
    public Room CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }
    public bool Playing { get; set; }

        public void Reset()
    {

    }

    public void Play()
    {
      // Console.Clear();
      Console.WriteLine(CurrentRoom.Description);
      if (CurrentRoom.Items.Count != 0)
      {
        for (var i = 0; i < CurrentRoom.Items.Count; i++)
        {
          System.Console.WriteLine(CurrentRoom.Items[i].Name);
        }

      }
      var choice = Console.ReadLine().ToLower();
      var splitChoice = choice.Split(" ");
      switch (splitChoice[0])
      {
        case "go":
          if (splitChoice.Length > 1)
          {
            CurrentRoom.Go(splitChoice[1]);
          }
          break;
        case "take":
          if (splitChoice.Length > 1)
          {
            TakeItem(splitChoice[1]);
          }
          break;
        case "use":
          if (splitChoice.Length > 1)
          {
            UseItem(splitChoice[1]);
          }
          break;
        case "inventory":
          if (choice == splitChoice[0])
          {
            CurrentPlayer.Inventory.ForEach(i => System.Console.WriteLine(i.Name + ":" + i.Description));

          }
          break;
      }

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
      Console.Clear();
      Room room0 = new Room("Roof", "This is the roof there are items");
      Item button = new Item("button", "a small button on a plate");
      Item fireBomb = new Item("fire bomb", "A round silver ball that you have been told will explode into fire and death!(great for parties!)");
      room0.Items.Add(button);
      room0.Items.Add(fireBomb);
      Room room1 = new Room("Room 1", "You go down the hatch into room 1");
      Room room2 = new Room("Room 2", "");
      Room room3 = new Room("Room 3", "");
      Room room4 = new Room("Room 4", "");
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


      room0.Exits.Add("button", room1);
      // room1.Exits.Add("", room2);



      CurrentRoom = room0;
      Player player1 = new Player("Bob");
      CurrentPlayer = player1;
      Playing = true;
    }



    public void UseItem(string itemName)
    {
      Item temp = CurrentPlayer.Inventory.Find(x => x.Name.Contains("fire bomb"));
      if (itemName == "button" && temp.Name == "fire bomb")
      {
        Console.WriteLine("You Die");
        Playing = false;

      }
      else
      {
        CurrentRoom = CurrentRoom.Go("button");
        System.Console.WriteLine(CurrentRoom.Name);
      }
    }


    public void TakeItem(string itemName)
    {
      System.Console.WriteLine(itemName);
      Item item = CurrentRoom.Items.Find(i => i.Name.Contains(itemName));
      Console.Clear();
      System.Console.WriteLine($"You Picked up the {item.Name} ");
      CurrentPlayer.Inventory.Add(item);
      CurrentRoom.Items.Remove(item);
    }
  }
}