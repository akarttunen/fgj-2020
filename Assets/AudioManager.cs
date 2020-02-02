using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource intro;
    public AudioSource music;
    public AudioSource auto;
    // Start is called before the first frame update
    void Start()
    {
        intro.Play();
        music.PlayDelayed(intro.clip.length);
    }
}
