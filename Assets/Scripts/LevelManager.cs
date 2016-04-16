using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

  // Use this for initialization
  void Start () {
    // Load Scene
    int currentIndex = SceneManager.GetActiveScene().buildIndex;
    SceneManager.LoadScene(currentIndex + 1);
  }

  // Update is called once per frame
  void Update () {

  }
}
