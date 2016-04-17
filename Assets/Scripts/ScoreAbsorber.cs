using UnityEngine;
using System.Collections;

public class ScoreAbsorber : MonoBehaviour {

  public int score;

  // Use this for initialization
  void Start () {
    // get old keeper, keep the score, destroy the old keeper object
    ScoreKeeper oldKeeper = FindObjectOfType<ScoreKeeper>();
    score = 0;
    if (oldKeeper) {
      score = oldKeeper.score;
      Destroy(oldKeeper.gameObject);
    }

  }

  // Update is called once per frame
  void Update () {

  }
}
