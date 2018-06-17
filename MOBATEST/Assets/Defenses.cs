using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenses : MonoBehaviour {

    public float Health;
    public float Armor_Rating;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Health <= 0f)
        {
            Destroy(gameObject);
        }
	}

    public void TakeDamage(int Damage)
    {
        Health = Health - (Damage);
    }
}
