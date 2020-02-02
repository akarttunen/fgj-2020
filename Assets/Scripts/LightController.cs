using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Component flashlight;

    // Start is called before the first frame update
    void Start()
    {
        flashlight = gameObject.GetComponent("Light");
        //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log(this.GetComponent<Light>().enabled);
            gameObject.GetComponent<Light>().enabled = !gameObject.GetComponent<Light>().enabled;
        }
    }
}
