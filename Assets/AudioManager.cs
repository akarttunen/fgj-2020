using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource intro;
    public AudioSource music;
    public AudioSource auto;
    public AudioSource burpSound;
    public AudioSource korkkaus;
    public AudioSource perjantai;
    // Start is called before the first frame update
    void Start()
    {
        intro.Play();
        music.PlayDelayed(intro.clip.length);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            burpSound.PlayOneShot(burpSound.clip);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            perjantai.PlayOneShot(perjantai.clip);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            korkkaus.PlayOneShot(korkkaus.clip);
        }
    }
}
