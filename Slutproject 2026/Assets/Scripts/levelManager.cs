using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
//Alexander

[System.Serializable]
public class levelManager : MonoBehaviour
{
    //Ian

    //public static levelManager instance;
    //public string LevelName;
    public List<levelConnect> ConnectedLevels = new List<levelConnect>();

    /*public void OnClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(LevelName);
    }*/
}


[System.Serializable]
public class levelConnect
{
    public List<int> ConnectedLevels = new List<int>();
}

public class Level
{

}
