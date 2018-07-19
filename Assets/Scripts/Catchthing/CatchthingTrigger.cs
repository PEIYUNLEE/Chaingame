using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchthingTrigger : MonoBehaviour {
    public int scoreValue;
    GameObject player;
    TestScoreManager testscoremanager;
    // Use this for initialization
    void Awake () {
        player = GameObject.FindGameObjectWithTag("Player");
        testscoremanager = GetComponent<TestScoreManager>();
    }
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
        if (other.gameObject == player)
        {
            Destroy(gameObject);
            TestScoreManager.gamescore += scoreValue;
        }
    }
}
