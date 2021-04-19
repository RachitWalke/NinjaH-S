using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenenav : MonoBehaviour {

    public void sceneloader (string name)
    {
        SceneManager.LoadScene(name);
    }
    public void quit()
    {
        Application.Quit();
    }


}
