﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour {

    public int Damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Defenses>().TakeDamage(Damage);
        }
    }
}
