using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private List<int> scenes = new List<int>();

    public void ChangeIntoMainScene()
    {
        SceneManager.LoadSceneAsync(scenes[0]);
    }

    public void ChangeIntoShop()
    {
        SceneManager.LoadSceneAsync(scenes[1]);
    }

    public void Start()
    {
        scenes.Add(0);
        scenes.Add(SceneManager.GetActiveScene().buildIndex + 1);
    }
}