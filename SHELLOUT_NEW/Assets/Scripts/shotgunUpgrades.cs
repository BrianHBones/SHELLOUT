using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class shotgunUpgrades : MonoBehaviour
{
    Kills gameTracker;
    
    public Button shotgunbuttonOne;
    public Button shotgunbuttonTwo;
    public Button shotgunbuttonThree;
    public Button shotgunbuttonFour;
    public Button shotgunbuttonFive;
    public Button shotgunbuttonSix;
    public Button shotgunbuttonSeven;

    void Start(){
        gameTracker = FindObjectOfType<Kills>();
    }
    public void shotgunUpgradeOne(){
        if(gameTracker.zombieKills >= 2200){
            gameTracker.zombieKills -= 2200;
            gameTracker.shotgunOne = true;
            gameTracker.shotgunMultiplier = 8;
            shotgunbuttonOne.interactable = false;
        }
    }
    public void shotgunUpgradeTwo(){
        if(gameTracker.zombieKills >= 2500){
            gameTracker.zombieKills -= 2500;
            gameTracker.timeBetweenShotsshotgun = 1.5f;
            shotgunbuttonTwo.interactable = false;
        }
    }
    public void shotgunUpgradeThree(){
        if(gameTracker.zombieKills >= 2700){
            gameTracker.zombieKills -= 2700;
            gameTracker.shotgunThree = true;
            shotgunbuttonThree.interactable = false;
        }
    }
    public void shotgunUpgradeFour(){
        if(gameTracker.zombieKills >= 3000){
            gameTracker.zombieKills -= 3000;
            gameTracker.shotgunFour = true;
            gameTracker.aboveThisRandomBurn = 125;
            shotgunbuttonFour.interactable = false;
        }
    }
    public void shotgunUpgradeFive(){
        if(gameTracker.zombieKills >= 3200){
            gameTracker.zombieKills -= 3200;
            gameTracker.shotgunFive = true;
            gameTracker.shotgunMultiplier = 12;
            shotgunbuttonFive.interactable = false;
        }
    }
    public void shotgunUpgradeSix(){
        if(gameTracker.zombieKills >= 3500){
            gameTracker.zombieKills -= 3500;
            gameTracker.timeBetweenShotsshotgun = 1f;
            shotgunbuttonSix.interactable = false;
        }
    }
    public void shotgunUpgradeSeven(){
        if(gameTracker.zombieKills >= 4000){
            gameTracker.zombieKills -= 4000;
            gameTracker.shotgunSeven = true;
            gameTracker.shotgunMultiplier = 16;
            shotgunbuttonSeven.interactable = false;
        }
    }
}
