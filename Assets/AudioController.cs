using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip[] pickupSounds;
    public AudioSource audioSourceObj;

    private int count = 0;
    
    public void PlayAudio()
    {
        audioSourceObj.PlayOneShot(pickupSounds[count]);
        count ++;
    }
}
