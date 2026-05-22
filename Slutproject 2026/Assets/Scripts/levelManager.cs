using JetBrains.Annotations;
using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
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
        }

    }
    
    public void onClick(string levelname)
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene(levelname);
    }
}
[System.Serializable]
public class level
{
    public int keyneeded;
    public int keygiven;
    public bool isLocked;
    

    public void UnlockLevels()
    {
        // Loop igenom varje level och jämföra keygiven med keyneeded

        if (keygiven == keyneeded)
        {
            isLocked = false;
        }
    }

    public void SetKeys(int keyNeeded, int keyGiven)
    {
        keyneeded = keyNeeded;
        keygiven = keyGiven;
    }
}
