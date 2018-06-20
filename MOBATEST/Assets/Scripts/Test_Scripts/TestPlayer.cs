using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour {

    public int player_health;
    public float player_speed;

    private Vector3 movement;
    private Rigidbody playerRigidbody;

    void Start () {
        playerRigidbody = GetComponent<Rigidbody>();
    }
	
	void Update () {
	}

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        MovePlayer(h, v);
    }

    void MovePlayer(float h, float v)
    {
        movement.Set(h, 0f, v);
        movement = movement.normalized * player_speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);        
    }
}
