using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public GameObject collectable;
    public AudioSource audioS;
    public AudioClip damageSound;
    public AudioClip deathSound;

    public void TakeDamage (float amount)
    {
        health -= amount;
        audioS.PlayOneShot(damageSound);
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        if (CheckIfDrop())
        {
            Instantiate(collectable, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z), Quaternion.identity);
        }
        audioS.PlayOneShot(deathSound);
        Destroy(gameObject);
    }

    bool CheckIfDrop()
    {
        Random.InitState((int)(System.DateTime.UtcNow.Subtract(new System.DateTime(1970, 1, 1))).TotalSeconds);
        if (Random.Range(0, 100) % 1 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    }
