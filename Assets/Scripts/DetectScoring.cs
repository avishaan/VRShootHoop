using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {

  public int pointValue = 1;
  // Use this for initialization
  void Start () {

  }

  // Update is called once per frame
  void Update () {

  }

  void OnCollisionEnter (Collision collision) {
    // find the component
    ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
    scoreKeeper.IncrementScore(pointValue);
  }
}
