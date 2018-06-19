using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
  public class Room : IRoom
  {

    public string Name { get; set; }
    public string Description { get; set; }
    public string Exits { get; set; }
    // public string Direction { get; set; }
    public List<Item> Items { get; set; }

    public void UseItem(Item item)
    {
      
    }
    public Room Go(string Description)
    {
      if (exits.ContainsKey(direction))
      {
       Console.WriteLine(description);
        return exits[description];
      }
    }
    public Room(string name, string description)
    {
      Name = name;
      Description = description;
      // Exits = exits;
      // Direction = direction; 
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