using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void LoadScene(string s)
    {
        SceneManager.LoadScene(s);
    }
}
