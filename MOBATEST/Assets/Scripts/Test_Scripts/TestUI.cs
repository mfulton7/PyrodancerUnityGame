using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TestUI : MonoBehaviour {

    public GameObject player;

    Defenses defenses;
    Text healthText;
    private int health;
    

	// Use this for initialization
	void Start () {
        defenses = player.GetComponent<Defenses>();
        healthText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        health = defenses.currentHealth;
        healthText.text = "Health: " + health;
	}
}
