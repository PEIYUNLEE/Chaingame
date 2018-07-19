using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScoreManager : MonoBehaviour {
    public static int gamescore;
    public Text scoretext;
	// Use this for initialization
	void Start () {
        scoretext = GetComponent<Text>();
        gamescore = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        scoretext.text = "Score : " + gamescore;
    }
}
