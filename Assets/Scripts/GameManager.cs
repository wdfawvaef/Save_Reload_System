﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public GameObject scorePanel;
    public int score = 0;
    
    private Text scoreText;

    public GameObject pausePanel;
    public GameObject pauseBtn;
    public bool canShoot=true;
    private Animator anim;
    public AnimationClip[] ac;

    void Awake() {
        canShoot = true;
    }
    // Start is called before the first frame update
    void Start() {
        instance = this;
        scoreText = scorePanel.GetComponent<Text>();
        anim = pausePanel.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        scoreText.text = "Score : " + score;
    }
    public void PauseGame() {
        canShoot = false;
        anim.SetBool("pause", true);
        pausePanel.SetActive(true);
        pauseBtn.SetActive(false);
    }
    public void ResumeGame() {
        Time.timeScale = 1;
        anim.SetBool("pause",false);
        canShoot = true;
    }

    public void NewGame() {
        canShoot = true;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void SaveGame() {
        Debug.Log("保存成功");
    }

    public void LoadGame() {

    }

    public void QuitGame() {

    }

    public void BGMController() {

    }
}
