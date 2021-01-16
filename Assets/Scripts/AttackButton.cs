using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttackButton : MonoBehaviour
{
    private GameManager gm;
    private GameObject displayText;
    private int strength = 2;
    
    private void Start() {
        displayText = GameObject.Find("DisplayText");
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void Attack()
    {
        TextMeshProUGUI tm = displayText.GetComponent<TextMeshProUGUI>();
        tm.text = "You attack the ennemy !";
        gm.EnnemyHp -= strength;
        gm.DisplayInfo(tm);
    }
}
