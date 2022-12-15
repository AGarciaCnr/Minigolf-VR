using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCanvasController : MonoBehaviour
{
    public void OnPlay()
    {
        SceneManager.LoadScene(AppConstant.AppScenes.SCENE_LEVEL_1);
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
