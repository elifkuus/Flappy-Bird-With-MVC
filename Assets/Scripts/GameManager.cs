using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
public GameObject gameOverCanvas;
public GameObject gameReadyCanvas;


private void Start(){

    gameReadyCanvas.SetActive(true);
    gameOverCanvas.SetActive(false);
    Time.timeScale = 1;

    
}

private void Update(){
    if(Input.GetMouseButtonDown(0)){
        gameReadyCanvas.SetActive(false);
    }
}
public void GameOver()
{
    gameOverCanvas.SetActive(true);
    Time.timeScale = 0;

}

public void Replay(){
    SceneManager.LoadScene(0);
}

}
