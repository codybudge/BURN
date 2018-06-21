using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
  public class Room : IRoom
  {

    public string Name { get; set; }
    public string Description { get; set; }
    public Dictionary<string, Room> Exits { get; set; }
    public List<Item> Items { get; set; }

    public void UseItem(Item item)
    {
      
    }
    
    
    public Room Go(string direction)
    {
      if (Exits.ContainsKey(direction))
      {
       Console.WriteLine(direction);
        return Exits[direction];
      }
      return null;
    }
    public Room(string name, string description)
    {
      Name = name;
      Description = description;
      Exits = new Dictionary<string, Room>();
      Items = new List<Item>();
     
    }
  }
}
/*
for taking items

public Item Takeitem(Item item)
{
  Items.Find(items): 
}


public rooms Go 

if exits.ContainsKey(direction)
{
  cw descritpion
  return exits [description]
}
*/