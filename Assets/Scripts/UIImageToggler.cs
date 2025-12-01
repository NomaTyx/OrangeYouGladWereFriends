using UnityEngine;
using UnityEngine.UI;

public class UIImageToggler : MonoBehaviour
{
    [SerializeField] Image uiImage;
    [SerializeField] Sprite cinemaImageSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SetCinemaImage()
    {
        uiImage.enabled = true;
        uiImage.sprite = cinemaImageSprite;
    }

    public void ResetImage()
    {
        uiImage.enabled = false;
    }
}
