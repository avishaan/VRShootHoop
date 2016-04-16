using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

  // Use this for initialization
  void Start () {

  }

  // Update is called once per frame
  void Update () {
    if (Input.GetKeyDown(KeyCode.Space)){
      string currentScene = SceneManager.GetActiveScene().name;
      switch (currentScene){
        case "Start Menu":
          LoadNextScene("Main");
          break;
        case "Main":
          LoadNextScene("End Menu");
          break;
      }
    }
  }

  void LoadNextScene(string sceneName) {
    // Load Scene
    SceneManager.LoadScene(sceneName);
  }
}
