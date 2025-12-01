using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] private GameObject heart;
    [SerializeField] private Health playerHealth;
    private List<GameObject> hearts;
    int heartIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        hearts = new List<GameObject>();
        for(int i = 0; i < playerHealth.MaxHealth; i++)
        {
            GameObject h = Instantiate(heart, gameObject.transform);
            hearts.Add(h);
        }
        heartIndex = playerHealth.MaxHealth - 1;
    }

    public void LoseHeart()
    {
        hearts[heartIndex].gameObject.SetActive(false);
        heartIndex--;
    }
}
