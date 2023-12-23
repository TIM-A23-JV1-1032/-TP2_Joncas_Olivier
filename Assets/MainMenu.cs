using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Scene.LoadSceneAsync(Scene_de_démarrage)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
