using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    public void Scene_Change()
    {
        SceneManager.LoadScene(sceneName);
    }
}
