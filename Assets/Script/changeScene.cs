using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void ButtonMoveScene (string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
