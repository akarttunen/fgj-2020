using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int collectedItems;
    public int currentHp;
    // Start is called before the first frame update
    void Start()
    {
        collectedItems = 0;
        currentHp = 100;
    }
    void AddCollectedItemAmount()
    {
        collectedItems++;
    }
    void AdjustHpAmount(int amount)
    {
        currentHp += amount;
    }
}
