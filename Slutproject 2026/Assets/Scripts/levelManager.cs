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
}
[System.Serializable]
public class level
{
    public int keyneeded;
    public int keygiven;
    public GameObject blah;
    public bool isLocked;
    public string LevelName;

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

    public void OnClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(LevelName);
    }

    public void LevelLock() //kollar om leveln är låst
    {
        if (isLocked == false)
        {
            OnClick();
        }
    }
}
