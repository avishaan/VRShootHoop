using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

  public float timeTillNextLevel = 0.0f;
  // Use this for initialization
  void Start () {

  }

  // Update is called once per frame
  void Update () {

    string currentScene = SceneManager.GetActiveScene().name;

    if (Input.GetKeyDown(KeyCode.Space)){
      switch (currentScene){
        case "Start Menu":
          LoadNextScene("Main");
          break;
        case "Main":
          LoadNextScene("End Menu");
          break;
        case "End Menu":
          LoadNextScene("Start Menu");
          break;
      }
    }

    // change level at a certain time
    if (timeTillNextLevel > 0.0){
      timeTillNextLevel -= Time.deltaTime;
    }
    if (timeTillNextLevel <= 0.0 && currentScene == "Main"){
      LoadNextScene("End Menu");
    }
  }

  public void LoadNextScene(string sceneName) {
    // Load Scene
    SceneManager.LoadScene(sceneName);
  }
}
