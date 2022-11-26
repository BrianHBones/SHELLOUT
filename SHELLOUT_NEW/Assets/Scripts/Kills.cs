using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Kills : MonoBehaviour
{
    [Header("main ints")]
    public int zombieKills = 0;
    public int piercing = 0;
    public int explosive = 0;
    public int fireRate = 0;
    
    [Header("modification amounts")]
    public float fireRateModification = 1.3f;

    [Header("modification total")]
    public float fireRateAmount = 20f;

    [Header("text")]
    public TextMeshProUGUI killText;
    public TextMeshProUGUI fireRateText;

    public void onButtonKill(){
        zombieKills += 1;
        killText.text = ("Kills: " + zombieKills);
    }

    public void FireRateBuy(){
        if(zombieKills >= fireRateAmount){
            fireRate++;
            fireRateAmount = fireRateAmount * fireRateModification;
            fireRateText.text = ("Owned: " + fireRate);
        }
    }

}
