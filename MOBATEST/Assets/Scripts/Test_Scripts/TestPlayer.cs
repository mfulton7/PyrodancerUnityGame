using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour {

    public float player_speed;

    private Vector3 movement;
    private Rigidbody playerRigidbody;
    private Vector3 moveDirection;
    private Transform transformer;

    void Start () {
        playerRigidbody = GetComponent<Rigidbody>();
        transformer = transform;
    }
	
	void Update () {
	}

    void FixedUpdate()
    {
        // Get Axises
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // Modifier if player is going diag or not
        float inputModifyFactor = (h != 0.0f && v != 0.0f) ? .7071f : 1.0f;

        // Move player in that direction
        moveDirection = new Vector3(h * inputModifyFactor, 0, v * inputModifyFactor);
        moveDirection = transformer.TransformDirection(moveDirection) * player_speed;
        playerRigidbody.MovePosition(transform.position + moveDirection * Time.deltaTime);
    }

}
