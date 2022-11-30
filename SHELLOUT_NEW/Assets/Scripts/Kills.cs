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
    public float fireRateModification = 2f;
    public float explosiveModification = 4f;
    public float pierceModification = 3f;
    public float pistolModification = 2f;
    public float shotgunModification = 3f;
    public float smgModification = 5f;

    [Header("pistol Upgrades")]
    public bool pistolOne = false;
    public bool pistolThree = false;
    public bool pistolFive = false;
    public bool pistolSix = false;
    int randomexplodeamount = 0;
    public int aboveThisRandom = 75;

    [Header("shotgun Upgrades")]
    public bool shotgunOne = false;
    public bool shotgunThree = false;
    public bool shotgunFour = false;
    public bool shotgunFive = false;
    public bool shotgunSeven = false;
    public int shotgunMultiplier = 4;
    int randomBurnamount = 0;
    public int aboveThisRandomBurn = 100;

    [Header("smg Upgrades")]
    public bool smgOne = false;
    public bool smgThree = false;
    public bool smgFour = false;
    public bool smgSix = false;
    public bool smgSeven = false;

    [Header("modification total")]
    public float fireRateAmount = 20f;
    public float explosiveAmount = 200f;
    public float pierceAmount = 70f;
    public float pistolAmount = 140f;
    public float shotgunAmount = 170f;
    public float smgAmount = 240f;

    [Header("text")]
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
    public float timeBetweenShotspistol = 1f;
    public bool canShootshotgun = true;
    public float timeBetweenShotsshotgun = 3f;
    public bool canShootsmg = true;
    public float timeBetweenShotssmg = .5f;

    void Start(){
        
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
        if(fireRate >= 1){
            zombieKills += fireRate;
        }
        if(piercing >= 1){
            zombieKills += piercing * 2;
        }
        if(explosive >= 1){
            zombieKills += explosive * 4;
        }
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
        if(pistolOne){
            zombieKills += pistol;
        }
        if(pistolThree){
            zombieKills += pistol + pistol;
        }
        if(pistolSix){
            zombieKills += pistol + pistol;
        }
        if(pistolFive){
            randomexplodeamount = Random.Range(0, aboveThisRandom);
            if(randomexplodeamount > 50){
                zombieKills += pistol + pistol + pistol + pistol;
            }
        }
        StartCoroutine(ShotCooldownpistol());
    }

    IEnumerator ShotCooldownpistol(){
        yield return new WaitForSeconds(timeBetweenShotspistol);
        canShootpistol = true;
    }

    private void Shootshotgun(){
        canShootshotgun = false;
        zombieKills += shotgun * shotgunMultiplier;
        if(shotgunThree){
            randomBurnamount = Random.Range(0, aboveThisRandomBurn);
            if(aboveThisRandomBurn > 75){
                zombieKills += shotgun * 2;
            }
        }
        StartCoroutine(ShotCooldownshotgun());
    }

    IEnumerator ShotCooldownshotgun(){
        yield return new WaitForSeconds(timeBetweenShotsshotgun);
        canShootshotgun = true;
    }

    private void Shootsmg(){
        canShootsmg = false;
        zombieKills += smg;
        if(smgOne){
            zombieKills += smg;
        }
        if(smgFour){
            zombieKills += smg;
        }
        if(smgThree){
            zombieKills += smg + smg;
        }
        if(smgSix){
            zombieKills += smg + smg;
        }
        if(smgSeven){
            zombieKills += smg + smg;
        }
        StartCoroutine(ShotCooldownsmg());
    }

    IEnumerator ShotCooldownsmg(){
        yield return new WaitForSeconds(timeBetweenShotssmg);
        canShootsmg = true;
    }
}
