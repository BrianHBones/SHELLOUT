using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class pistolUpgrades : MonoBehaviour
{
    Kills gameTracker;
    
    public Button pistolbuttonOne;
    public Button pistolbuttonTwo;
    public Button pistolbuttonThree;
    public Button pistolbuttonFour;
    public Button pistolbuttonFive;
    public Button pistolbuttonSix;
    public Button pistolbuttonSeven;

    void Start(){
        gameTracker = FindObjectOfType<Kills>();
    }
    public void pistolUpgradeOne(){
        if(gameTracker.zombieKills >= 200){
            gameTracker.zombieKills -= 200;
            gameTracker.pistolOne = true;
            pistolbuttonOne.interactable = false;
        }
    }
    public void pistolUpgradeTwo(){
        if(gameTracker.zombieKills >= 300){
            gameTracker.zombieKills -= 300;
            gameTracker.timeBetweenShotspistol = .7f;
            pistolbuttonTwo.interactable = false;
        }
    }
    public void pistolUpgradeThree(){
        if(gameTracker.zombieKills >= 400){
            gameTracker.zombieKills -= 400;
            gameTracker.pistolThree = true;
            pistolbuttonThree.interactable = false;
        }
    }
    public void pistolUpgradeFour(){
        if(gameTracker.zombieKills >= 1000){
            gameTracker.zombieKills -= 1000;
            gameTracker.pistolFive = true;
            pistolbuttonFour.interactable = false;
        }
    }
    public void pistolUpgradeFive(){
        if(gameTracker.zombieKills >= 1200){
            gameTracker.zombieKills -= 1200;
            gameTracker.timeBetweenShotspistol = .55f;
            pistolbuttonFive.interactable = false;
        }
    }
    public void pistolUpgradeSix(){
        if(gameTracker.zombieKills >= 1300){
            gameTracker.zombieKills -= 1300;
            gameTracker.pistolSix = true;
            pistolbuttonSix.interactable = false;
        }
    }
    public void pistolUpgradeSeven(){
        if(gameTracker.zombieKills >= 2000){
            gameTracker.zombieKills -= 2000;
            gameTracker.aboveThisRandom = 25;
            pistolbuttonSeven.interactable = false;
        }
    }
}
