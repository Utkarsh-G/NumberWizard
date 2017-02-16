using UnityEngine;
using System.Collections;
//using UnityEditor.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(int sceneIndex)
    {
        Debug.Log("Level load requested for: " + sceneIndex);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);

    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested.");

    }
	
}
