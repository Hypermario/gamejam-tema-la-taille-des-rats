using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    
    public int scene;
    public string nameSceneToLoad;

    void Start(){
        
    }


    void Update(){
        
    }

    public void SwitchScene(){
        SceneManager.LoadScene(sceneBuildIndex: scene);
    }

    public void BackToMainMenu(){
        SceneManager.LoadScene (nameSceneToLoad);
    }
}
