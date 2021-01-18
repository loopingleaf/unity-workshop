using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int Hp { get { return hp; } set { hp = Mathf.Max(0, value); } }
    public int EnnemyHp { get { return ennemyHp; } set { ennemyHp = Mathf.Max(0, value); } }
    private int hp = 7;
    private int ennemyHp = 8;
    private bool isRestart = false;

    public void DisplayInfo(TextMeshProUGUI tm)
    {
        if(isRestart)
        {
            hp = 7;
            ennemyHp = 8;
            tm.text = "Okay, let's try again";
            isRestart = false;
        }
        tm.text += "\nHPs: " + Hp + " - Ennemy's HPs: " + EnnemyHp;
        if(hp <= 0)
        {
            tm.text += "\nYou are dead...";
            AskForRestart(tm);
        }
        else if (ennemyHp <= 0)
        {
            tm.text = "You win !";
            AskForRestart(tm);
        }
    }

    private void AskForRestart(TextMeshProUGUI tm)
    {
        tm.text += "\nPress a button to restart";
        isRestart = true;
    }
}
