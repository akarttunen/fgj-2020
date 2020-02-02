using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public float damageTime = 2f;
    public float damageAmount = 25f;
    public AudioSource audioS;
    public AudioClip damageSound;
    // Start is called before the first frame update
    private float damageFrequency = 0f;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Time.time >= damageFrequency)
        {
            Debug.Log("Damage taken");
            audioS.PlayOneShot(damageSound);
            damageFrequency = Time.time + damageTime;
        }
    }
}
