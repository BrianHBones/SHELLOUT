using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Kills : MonoBehaviour
{
    [Header("main ints")]
    public float zombieKills = 0f;
    public int piercing = 0;
    public int explosive = 0;
    public int fireRate = 0;
    
    [Header("modification amounts")]
    public float fireRateModification = 1.3f;
    public float explosiveModification = 2f;
    public float pierceModification = 1.6f;

    [Header("modification total")]
    public float fireRateAmount = 20f;
    public float explosiveAmount = 200f;
    public float pierceAmount = 70f;

    [Header("text")]
    public TextMeshProUGUI killText;
    public TextMeshProUGUI fireRateText;
    public TextMeshProUGUI explosiveText;
    public TextMeshProUGUI pierceText;
    public TextMeshProUGUI tonextfireRateText;
    public TextMeshProUGUI tonextexplosiveText;
    public TextMeshProUGUI tonextpierceText;

    void Start(){
        fireRateText.text = ("Owned: " + fireRate);
        explosiveText.text = ("Owned: " + explosive);
        pierceText.text = ("Owned: " + piercing);

        tonextfireRateText.text = ("Next: " + fireRateAmount);
        tonextexplosiveText.text = ("Next: " + explosiveAmount);
        tonextpierceText.text = ("Next: " + pierceAmount);
    }
    public void onButtonKill(){
        zombieKills += 1;
        killText.text = ("Kills: " + zombieKills);
    }

    public void FireRateBuy(){
        if(zombieKills >= fireRateAmount){
            fireRate++;
            zombieKills -= fireRateAmount;
            fireRateAmount = fireRateAmount * fireRateModification;
            fireRateText.text = ("Owned: " + fireRate);
            tonextfireRateText.text = ("Next: " + fireRateAmount);
        }
    }

    public void explosiveBuy(){
        if(zombieKills >= explosiveAmount){
            explosive++;
            zombieKills -= explosiveAmount;
            explosiveAmount = explosiveAmount * explosiveModification;
            explosiveText.text = ("Owned: " + explosive);
            tonextexplosiveText.text = ("Next: " + explosiveAmount);
        }
    }

    public void pierceBuy(){
        if(zombieKills >= pierceAmount){
            piercing++;
            zombieKills -= pierceAmount;
            pierceAmount = pierceAmount * pierceModification;
            pierceText.text = ("Owned: " + piercing);
            tonextpierceText.text = ("Next: " + pierceAmount);
        }
    }
}
