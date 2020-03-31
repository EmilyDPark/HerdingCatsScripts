using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayOptionsClick : MonoBehaviour
{
    public string noLimitScene;
    public string timeLimitScene;
    public string fenceLimitScene;
    public string mainMenuScene;
    public string levelScene;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NoLimit()
    {
        SceneManager.LoadScene(noLimitScene);
    }

    public void TimeLimit()
    {
        SceneManager.LoadScene(timeLimitScene);
    }

    public void FenceLimit()
    {
        SceneManager.LoadScene(fenceLimitScene);
    }

    public void Back()
    {
        SceneManager.LoadScene(mainMenuScene);
    }

    public void Play()
    {
        SceneManager.LoadScene(levelScene);
    }
}
