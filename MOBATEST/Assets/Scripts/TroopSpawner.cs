using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopSpawner : MonoBehaviour {

    public GameObject Troop_Prefab;
    public int Spawn_Rate;
    private float SpawnTimer;

	// Use this for initialization
	void Start () {
        SpawnTimer = Spawn_Rate;
	}
	
	// Update is called once per frame
	void Update () {
        SpawnTimer -= Time.deltaTime;
        if (SpawnTimer <= 0f)
        {
            //spawn troop
            Instantiate(Troop_Prefab, GetComponent<Transform>().position + new Vector3 (1,0,1), new Quaternion());
            SpawnTimer = Spawn_Rate;
        }
	}
}
