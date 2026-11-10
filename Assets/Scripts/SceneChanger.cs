using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private List<int> scenes = new List<int>();

    public void ChangeIntoMainScene()
    {
        SceneManager.LoadScene(scenes[0]);
    }

    public void ChangeIntoShop()
    {
        SceneManager.LoadScene(scenes[1]);
    }

    public void ChangeIntoStatistics()
    {
        SceneManager.LoadScene(scenes[2]);
    }

    public void Start()
    {
        scenes.Add(0);
        scenes.Add(SceneManager.GetActiveScene().buildIndex + 1);
        scenes.Add(SceneManager.GetActiveScene().buildIndex + 2);
    }
}