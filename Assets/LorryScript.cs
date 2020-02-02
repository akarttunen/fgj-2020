using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LorryScript : MonoBehaviour
{
    public GameManager gameManager;
    private Scene _currentScene;

    private void Start()
    {
        _currentScene = SceneManager.GetActiveScene();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (gameManager.collectedItems >= 5)
            {
                SceneManager.LoadScene(_currentScene.name);
                Debug.Log("Noice, collected items amount: " + gameManager.collectedItems);
            }
            else
            {
                Debug.Log("Could not finish, collected items amount: " + gameManager.collectedItems);
            }
        }
    }
}
