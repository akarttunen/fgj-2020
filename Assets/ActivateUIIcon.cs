using UnityEngine;
using UnityEngine.UI;

public class ActivateUIIcon : MonoBehaviour
{
    private Image _image;
    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        // Great piece of code
        if (Input.GetKeyDown(KeyCode.U))
        {
            ActivateUIICon();
        }
    }
    void ActivateUIICon()
    {
        _image.color = new Color(255f, 255f, 255f, 1f);
    }
}
