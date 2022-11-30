using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class smgUpgrade : MonoBehaviour
{
    Kills gameTracker;
    
    public Button smgbuttonOne;
    public Button smgbuttonTwo;
    public Button smgbuttonThree;
    public Button smgbuttonFour;
    public Button smgbuttonFive;
    public Button smgbuttonSix;
    public Button smgbuttonSeven;

    void Start(){
        gameTracker = FindObjectOfType<Kills>();
    }
    public void smgUpgradeOne(){
        if(gameTracker.zombieKills >= 4200){
            gameTracker.zombieKills -= 4200;
            gameTracker.smgOne = true;
            smgbuttonOne.interactable = false;
        }
    }
    public void smgUpgradeTwo(){
        if(gameTracker.zombieKills >= 4500){
            gameTracker.zombieKills -= 4500;
            gameTracker.timeBetweenShotssmg = .3f;
            smgbuttonTwo.interactable = false;
        }
    }
    public void smgUpgradeThree(){
        if(gameTracker.zombieKills >= 4700){
            gameTracker.zombieKills -= 4700;
            gameTracker.smgThree = true;
            smgbuttonThree.interactable = false;
        }
    }
    public void smgUpgradeFour(){
        if(gameTracker.zombieKills >= 5000){
            gameTracker.zombieKills -= 5000;
            gameTracker.smgFour = true;
            smgbuttonFour.interactable = false;
        }
    }
    public void smgUpgradeFive(){
        if(gameTracker.zombieKills >= 5200){
            gameTracker.zombieKills -= 5200;
            gameTracker.timeBetweenShotssmg = .15f;
            smgbuttonFive.interactable = false;
        }
    }
    public void smgUpgradeSix(){
        if(gameTracker.zombieKills >= 5500){
            gameTracker.zombieKills -= 5500;
            gameTracker.smgSix = true;
            smgbuttonSix.interactable = false;
        }
    }
    public void smgUpgradeSeven(){
        if(gameTracker.zombieKills >= 6000){
            gameTracker.zombieKills -= 6000;
            gameTracker.smgSeven = true;
            smgbuttonSeven.interactable = false;
        }
    }
}
