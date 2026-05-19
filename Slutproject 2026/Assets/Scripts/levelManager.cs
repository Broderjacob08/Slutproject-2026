using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
//Ian

[System.Serializable]
public class levelManager : MonoBehaviour
{
    
    //public static levelManager instance;
    //public string LevelName;

    /*public void OnClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(LevelName);
    }*/

    public List<level> Levels = new List<level>();

    public void UnlockLevels()
    {
        // Loop igenom varje level och jämföra keygiven med keyneeded

        
    }
}
[System.Serializable]
public class level
{
    public int keyNeeded;
    public int keyGiven;
    public GameObject blah;
    public bool isLocked;

    
}

public class LevelLock //check if the level is locked or not
{

}
