using System.Collections;
using UnityEngine;

public class DestroyAfter5Seconds : MonoBehaviour
{
    void Start()
    {
        //Fade Away the object instanstly
        StartCoroutine(Destroy());
    }

    IEnumerator Destroy()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        Destroy(gameObject);
    }
}
