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

    public string keyneeded;
    public string keygiven;
    public bool isLocked;

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
