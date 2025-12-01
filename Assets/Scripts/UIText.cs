using TMPro;
using UnityEngine;

public class UIText : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void setText(string s)
    {
        GetComponent<TextMeshProUGUI>().text = s;
    }

    public void RestoreText()
    {
        GetComponent<TextMeshProUGUI>().text = "Get close to stuff to see text!";
    }
}
