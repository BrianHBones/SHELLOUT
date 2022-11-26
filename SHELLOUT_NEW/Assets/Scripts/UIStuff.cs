using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIStuff : MonoBehaviour
{
    public TextMeshProUGUI killText;
    public TextMeshProUGUI killTextupgrades;
    Kills gameTracker;

    void Start(){
        gameTracker = FindObjectOfType<Kills>();
        killText.text = ("Kills: " + gameTracker.zombieKills);
        killTextupgrades.text = ("Kills: " + gameTracker.zombieKills);
    }

    void Update()
    {
        killText.text = ("Kills: " + gameTracker.zombieKills);
        killTextupgrades.text = ("Kills: " + gameTracker.zombieKills);
    }
}
