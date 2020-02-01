using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public GameObject collectable;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
            Instantiate(collectable, new Vector3(transform.position.x, transform.position.y + 5, transform.position.z), Quaternion.identity);
        if(CheckIfDrop())
        {
        }
        Debug.Log(CheckIfDrop());
        Destroy(gameObject);
    }

    bool CheckIfDrop()
    {
        Random.InitState((int)(System.DateTime.UtcNow.Subtract(new System.DateTime(1970, 1, 1))).TotalSeconds);
        if(Random.Range(0, 100) % 4 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
