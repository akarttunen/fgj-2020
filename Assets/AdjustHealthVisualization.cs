using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustHealthVisualization : MonoBehaviour
{
    private Transform _initialTransform;
    // Start is called before the first frame update
    void Start() {
        // Just testing stuff
    _initialTransform = GetComponent<RectTransform>();
        Debug.Log(_initialTransform.localPosition);
    }
    void Update()
    {
        // Test purposes delete before release
        if (Input.GetKeyDown(KeyCode.P))
        {
            AdjustHealthBar(20);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            AdjustHealthBar(-20);
        }
    }

    private void AdjustHealthBar(int amount)
    {
        // Very strange magig, made quickly
        // Range = 380 => 580
        if (amount != 20 && amount != -20)
        {
            Debug.LogWarning("You shall not use value different than 20 or -20, tried to use amount: " + amount);
            return;
        }
        gameObject.transform.localPosition = new Vector3(transform.localPosition.x + amount, transform.localPosition.y, transform.localPosition.z);
        Debug.Log($"Adjusting health bar {amount}");
    }
}
