using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int collectedItems;
    public int currentHp;
    public GameObject uiImageContainer;
    public Image[] uiImages;
    public AudioSource endSound;
    public AudioSource music;
    public AudioSource newMusic;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        collectedItems = 0;
        currentHp = 100;
    }
    public void AddCollectedItemAmount()
    {
        ActivateUIImage();
        collectedItems++;
    }
    void AdjustHpAmount(int amount)
    {
        currentHp += amount;
    }
    void ActivateUIImage()
    {
        Image currentUIImage = uiImages[collectedItems];
        Debug.Log($"Activating image {currentUIImage.name}");
        currentUIImage.color = new Color(255f, 255f, 255f, 1f);
    }
    public void PlayEndSound()
    {
        music.Stop();
        newMusic.Play();
        endSound.Play();
    }
}
