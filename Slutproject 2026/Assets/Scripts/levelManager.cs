using JetBrains.Annotations;
using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
//Ian

[System.Serializable]
public class levelManager : MonoBehaviour
{
    
    public static levelManager instance;
    public string LevelName;

    public List<level> Levels = new List<level>();

    private void Start()
    {
        int index = 0;

        foreach(level l in Levels)
        {
            l.SetKeys(index, index + 1);
            index++;
            l.UnlockLevels();
        }
    }
    
    public void onClick(string LevelName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(LevelName);
        Debug.Log("har tryckt på knapp");
    }
}
[System.Serializable]
public class level
{
    public int keyneeded;
    public int keygiven;
    public bool isLocked;
    public Button levelButton;
    

    public void UnlockLevels()
    {
        // Loop igenom varje level och jämföra keygiven med keyneeded

        if (keygiven == keyneeded)
        {
            isLocked = false;

        }

        levelButton.interactable = !isLocked;
    }

    public void SetKeys(int keyNeeded, int keyGiven)
    {
        keyneeded = keyNeeded;
        keygiven = keyGiven;
    }
}
