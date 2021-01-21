using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int maxNbLevels;
    private List<Room> dungeon;

    void Start()
    {
        GenerateDungeon();
    }

    private void GenerateDungeon()
    {
        int nbDirections = Enum.GetNames(typeof(Room.Direction)).Length;
        for(int i = 0; i < maxNbLevels; i++)
        {
            Room[] roomTypeList = GenerateRoomTypes(nbDirections);
            foreach(Room.Direction dir in Enum.GetValues(typeof(Room.Direction)))
            {
                new Room(i, )
            }
        }
    }

    private Room[] GenerateRoomTypes(int size)
    {
        Room[] retval = new Room[size];
        string fightRoomText = "An monster !";
        string treasureRoomText = "A treasure !";
        string fightTreasureRoom = "An treasure... guarded by a monster !";
        // TODO
        return retval;
    }
}
