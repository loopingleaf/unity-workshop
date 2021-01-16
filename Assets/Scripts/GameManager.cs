using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int hp = 7;
    private int ennemyHp = 8;
    public int Hp { get { return hp; } set { hp = Mathf.Max(0, value); } }
    public int EnnemyHp { get { return ennemyHp; } set { ennemyHp = Mathf.Max(0, value); } }

    public void DisplayInfo(TextMeshProUGUI tm)
    {
        tm.text += "\nHPs: " + Hp + " - Ennemy's HPs: " + EnnemyHp;
        if(hp <= 0)
        {
            tm.text += "\nYou are dead...";
        }
        else if (ennemyHp <= 0)
        {
            tm.text += "\nYou win !";
        }
    }

}
