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
    public int pistol = 0;
    public int shotgun = 0;
    public int smg = 0;

    
    [Header("modification amounts")]
    public float fireRateModification = 1.3f;
    public float explosiveModification = 2f;
    public float pierceModification = 1.6f;
    public float pistolModification = 2f;
    public float shotgunModification = 2.5f;
    public float smgModification = 3f;


    [Header("modification total")]
    public float fireRateAmount = 20f;
    public float explosiveAmount = 200f;
    public float pierceAmount = 70f;
    public float pistolAmount = 140f;
    public float shotgunAmount = 170f;
    public float smgAmount = 240f;


    [Header("text")]
    public TextMeshProUGUI killText;

    public TextMeshProUGUI fireRateText;
    public TextMeshProUGUI explosiveText;
    public TextMeshProUGUI pierceText;

    public TextMeshProUGUI tonextfireRateText;
    public TextMeshProUGUI tonextexplosiveText;
    public TextMeshProUGUI tonextpierceText;

    public TextMeshProUGUI pistolText;
    public TextMeshProUGUI tonextpistolText;
    public TextMeshProUGUI shotgunText;
    public TextMeshProUGUI tonextshotgunText;
    public TextMeshProUGUI smgText;
    public TextMeshProUGUI tonextsmgText;

    [Header("auto amounts")]
    public bool canShootpistol = true;
    float timeBetweenShotspistol = 1f;
    public bool canShootshotgun = true;
    float timeBetweenShotsshotgun = 3f;
    public bool canShootsmg = true;
    float timeBetweenShotssmg = .5f;

    void Start(){
        killText.text = ("Kills: " + zombieKills);
        fireRateText.text = ("Owned: " + fireRate);
        explosiveText.text = ("Owned: " + explosive);
        pierceText.text = ("Owned: " + piercing);

        tonextfireRateText.text = ("Next: " + fireRateAmount);
        tonextexplosiveText.text = ("Next: " + explosiveAmount);
        tonextpierceText.text = ("Next: " + pierceAmount);

        pistolText.text = ("Owned: " +  pistol);
        tonextpistolText.text = ("Next: " +  pistolAmount);

        shotgunText.text = ("Owned: " +  shotgun);
        tonextshotgunText.text = ("Next: " +  shotgunAmount);

        smgText.text = ("Owned: " +  smg);
        tonextsmgText.text = ("Next: " +  smgAmount);
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

    public void pistolBuy(){
        if(zombieKills >= pistolAmount){
            pistol++;
            zombieKills -=  pistolAmount;
            pistolAmount =  pistolAmount *  pistolModification;
            pistolText.text = ("Owned: " +  pistol);
            tonextpistolText.text = ("Next: " +  pistolAmount);
        }
    }

    public void shotgunBuy(){
        if(zombieKills >= shotgunAmount){
            shotgun++;
            zombieKills -=  shotgunAmount;
            shotgunAmount =  shotgunAmount *  shotgunModification;
            shotgunText.text = ("Owned: " +  shotgun);
            tonextshotgunText.text = ("Next: " +  shotgunAmount);
        }
    }

    public void smgBuy(){
        if(zombieKills >= smgAmount){
            smg++;
            zombieKills -=  smgAmount;
            smgAmount =  smgAmount *  smgModification;
            smgText.text = ("Owned: " +  smg);
            tonextsmgText.text = ("Next: " +  smgAmount);
        }
    }

    void Update()
    {
        if(canShootpistol && pistol >= 1){
            Shootpistol();
        }
        if(canShootshotgun && shotgun >= 1){
            Shootshotgun();
        }
        if(canShootsmg && smg >= 1){
            Shootsmg();
        }
    }

    private void Shootpistol(){
        canShootpistol = false;
        zombieKills += pistol;
        killText.text = ("Kills: " + zombieKills);
        StartCoroutine(ShotCooldownpistol());
    }

    IEnumerator ShotCooldownpistol(){
        yield return new WaitForSeconds(timeBetweenShotspistol);
        canShootpistol = true;
    }

    private void Shootshotgun(){
        canShootshotgun = false;
        zombieKills += shotgun * 4;
        killText.text = ("Kills: " + zombieKills);
        StartCoroutine(ShotCooldownshotgun());
    }

    IEnumerator ShotCooldownshotgun(){
        yield return new WaitForSeconds(timeBetweenShotsshotgun);
        canShootshotgun = true;
    }

    private void Shootsmg(){
        canShootsmg = false;
        zombieKills += smg;
        killText.text = ("Kills: " + zombieKills);
        StartCoroutine(ShotCooldownsmg());
    }

    IEnumerator ShotCooldownsmg(){
        yield return new WaitForSeconds(timeBetweenShotssmg);
        canShootsmg = true;
    }
}
