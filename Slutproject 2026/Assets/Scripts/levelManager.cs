using UnityEngine;

public class levelManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public static levelManager instance;
    public string LevelName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            
    }
    public void OnClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(LevelName);
    }
}
