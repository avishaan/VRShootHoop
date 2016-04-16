using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

  private int score = 0;

  public void IncrementScore (int pointValue){
    score = score + pointValue;
    print("your score is: " + score);
  }
}
