using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_load : MonoBehaviour {

    public string NewGameSceneName;

     public void Load(){
        SceneManager.LoadScene(NewGameSceneName);
    }
}
