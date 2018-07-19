using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartManager : MonoBehaviour {
    public GameObject[] lifelove;
    public PlayerHealth playerHealth;
    GameObject player;
    // Use this for initialization
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }
	
	public void DecreaseLife() {
        lifelove[playerHealth.currentHealth].SetActive(false);
    }
}
