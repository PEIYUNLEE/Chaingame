using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameManager : Game {
    PlayerHealth playerHealth;
    TestScoreManager testscoremanager;
    // Use this for initialization
    protected override void Awake() {
        playerHealth = GetComponent<PlayerHealth>();
        testscoremanager= GetComponent<TestScoreManager>();
    }

    // Update is called once per frame
    protected override void Update ()
    {
        GameCleared();
    }

    private void GameCleared()
    {
        if (PlayerHealth.isDead || TestScoreManager.gamescore < 0)
        {
            isCleared = false;
        }
        else isCleared = true;
    }
}
