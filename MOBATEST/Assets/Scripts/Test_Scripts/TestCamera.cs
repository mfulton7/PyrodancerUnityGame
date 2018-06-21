using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCamera : MonoBehaviour {

    public GameObject player;
    public float mouse_sensitivity;

    private Vector3 offset;
    private float mouseX;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update () {
        if (player)
        {
            mouseX = Input.GetAxis("Mouse X") * mouse_sensitivity;
            transform.Rotate(0, mouseX, 0);
            player.transform.Rotate(0, mouseX, 0);

            transform.position = player.transform.position + offset;
        }
	}

}
