using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefenseButton : MonoBehaviour
{
    private GameManager gm;
    private GameObject displayText;
    private int heal = 3;

    private void Start() {
        displayText = GameObject.Find("DisplayText");
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void Defense()
    {
        TextMeshProUGUI tm = displayText.GetComponent<TextMeshProUGUI>();
        tm.text = "You heal !";
        gm.Hp += heal;
        gm.DisplayInfo(tm);
    }
}
