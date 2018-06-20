using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public int Damage_Per_Hit;
    public SphereCollider Tower_Radius;
    public GameObject Ammo_Prefab;
    public float Bullet_Speed;
    public float Time_Between_Attacks;
    public List<GameObject> Target_List;
    public GameObject Current_Target;
    private float Attack_Timer;

	// Use this for initialization
	void Start () {
        Attack_Timer = Time_Between_Attacks;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        Attack_Timer -= Time.fixedDeltaTime;
        //find way to refresh current target
        if (Attack_Timer <= 0f)
        {
            if (Target_List.Count > 0)
            {
                //temp check for null needs redone when we fix 0
                if (Target_List[0] != null)
                {
                    Vector3 towerToTarget = Target_List[0].gameObject.transform.position - GetComponent<Transform>().position;
                    Attack(towerToTarget);
                }
            }
            Attack_Timer = Time_Between_Attacks;
        }
    }

    void Attack(Vector3 targetLocation)
    {
        //spawn ammo prefab
        //set direction and velocity towards target location
        GameObject bullet = Instantiate(Ammo_Prefab, GetComponent<Transform>().position + new Vector3(0, 1, 0), new Quaternion(0,0,0,0));
        bullet.GetComponent<Rigidbody>().velocity = targetLocation * Bullet_Speed;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered Tower Radius...");
        if (other.tag == "Enemy")
        {
            Target_List.Add(other.gameObject);
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Object Left Tower Radius>>>");
        if (other.tag == "Enemy")
        {
            Target_List.Remove(other.gameObject);
        }
    }
}
