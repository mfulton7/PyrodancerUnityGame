using System.Collections;
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

    void fixedUpdate()
    {
        //transform.position = ;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Defenses>().TakeDamage(Damage);

            // Remove when we have a bullet manager

            Destroy(gameObject);
        }
    }
}
