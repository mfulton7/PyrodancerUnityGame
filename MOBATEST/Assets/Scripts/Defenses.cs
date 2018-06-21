using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenses : MonoBehaviour
{

    public int Health;
    public int Armor_Rating;
    public Vector3 respawnPoint;
    public int currentHealth;

    // Use this for initialization
    void Start()
    {
        currentHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0f)
        {
            transform.position = respawnPoint;
            currentHealth = Health;

        }
    }

    public void TakeDamage(int Damage)
    {
        currentHealth = currentHealth - (Damage);
    }
}