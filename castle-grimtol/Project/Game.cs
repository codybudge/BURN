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
        case "Go":
        case "g":
          if (splitChoice.Length > 1)
          {
           CurrentRoom = CurrentRoom.Go(splitChoice[1]);
          }
          break;
        case "take":
        case "Take":
        case "t":
          if (splitChoice.Length > 1)
          {
            TakeItem(splitChoice[1]);
          }
          break;
        case "use":
        case "Use":
        case "u":
          if (splitChoice.Length > 1)
          {
            UseItem(splitChoice[1]);
          }
          break;
        case "inventory":
        case "Inventroy":
        case "i":
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
      Room room0 = new Room("The Roof", "You start in a plane. Well you really start diving out of a plane towards a strange ship that has just lanned on earth! You land on the roof of the ship. There is this strange spire about 30ft high with a large ball at the end of it, it seems to be sucking in all of the surounding clouds.");
      Item button = new Item("button", "a small button on a plate");
      Item fireBomb = new Item("fire bomb", "A round silver ball that you have been told will explode into fire and death!(great for parties!)");
      Item sword = new Item("sword", "Your basic hero sword, not super sharp but can withstand attacks form enemys");
      room0.Items.Add(button);
      room0.Items.Add(fireBomb);
      Room room1 = new Room("Room 1", "You go down the hatch into room 1");
      Room room2 = new Room("Room 2", "You go into room 2");
      room2.Items.Add(sword);
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
      room1.Exits.Add("south", room3);
      room1.Exits.Add("east", room2);
      room2.Exits.Add("west", room1);
      room2.Exits.Add("south", room4);
      room3.Exits.Add("north", room2);
      room4.Exits.Add("north", room2);
      // room4.Exits.Add("down", room5);
      // room2.Exits.Add("", room);
      // room2.Exits.Add("", room);
      // room2.Exits.Add("", room);



      CurrentRoom = room0;
      Player player1 = new Player("Bob");
      CurrentPlayer = player1;
      Playing = true;
    }

public void Look(string look)
{

}

    public void UseItem(string itemName)
    {
      
      Item temp = CurrentPlayer.Inventory.Find(x => x.Name.Contains("fire bomb"));
       System.Console.WriteLine(itemName == "button" && temp != null);
      if (itemName == "button" && temp != null)
      {
        Console.WriteLine("You Die");
        Playing = false;

      }
      else if(itemName == "fire bomb")
      {
        System.Console.WriteLine("You look at the strange round ball in your hands. It has a small pin on it, you decide it would be a good idea to pull the pin(why...they could never find out). You can imagine what happens next. They only thing they found was a small pile of ash.....R.I.P Bob the idiot!");
        Playing = false;
      }
      else
      {
        CurrentRoom = CurrentRoom.Go("button");
        System.Console.WriteLine(CurrentRoom.Name);
      }
    //   switch(itemName)
    //   {
    //     case "button":
        
        
    //   }
    // }

    // public void UseButton(string itemName)
    // {
    //   Item temp = CurrentPlayer.Inventory.Find(x => x.Name.Contains("fire bomb"));
    //     System.Console.WriteLine(itemName == "button" && temp != null);
    //    if (itemName == "button" && temp != null)
    //    {
    //      Console.WriteLine("You Die");
    //      Playing = false;
    //    }else
    //    {
    //      CurrentRoom = CurrentRoom.Go("button");
    //     System.Console.WriteLine(CurrentRoom.Name);
    //    }
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