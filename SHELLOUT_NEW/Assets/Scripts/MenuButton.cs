using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MenuButton : MonoBehaviour
{
    [SerializeField] float gameStartDelay = 3f;
    public GameObject mainScreen;
    public Button playButton;
    public Button bonusButton;

    AudioPlayer audioPlayer;

    public void OnButtonStartGame(){
        StartCoroutine(GameStartDelay());
    }
    
    public void OnButtonQuit(){
        Debug.Log("Exiting");
        Application.Quit();
    }
    IEnumerator GameStartDelay(){
        yield return new WaitForSeconds(gameStartDelay);
        SceneManager.LoadScene("Game Scene");
    }
}
