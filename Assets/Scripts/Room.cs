using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    public enum Direction { Left, Front, Right };

    public int level;
    public string onEnterText;
    public Item treasure;
    public Enemy enemy;
    public Room Parent {
        get {return parent;}
        set {
            if(parent != null)
                Debug.Log("WARNING: Parent of room already set");
            parent = value;
        }
    }
    private Room parent;
    private Dictionary<Room, Direction> childs = new Dictionary<Room, Direction>();

    public Room(string onEnterText, Enemy enemy = null, Item treasure = null)
    {
        this.onEnterText = onEnterText;
        this.enemy = enemy;
        this.treasure = treasure;
    }

    public void AddChild(Room room, Direction direction)
    {
        room.parent = this;
        childs.Add(room, direction);
    }
}
