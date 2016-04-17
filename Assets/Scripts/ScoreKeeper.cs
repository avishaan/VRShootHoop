using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

  public int score = 0;

  void Start(){
    DontDestroyOnLoad(gameObject);
  }
  public void IncrementScore (int pointValue){
    score = score + pointValue;
    print("your score is: " + score);
  }
  public int GetScore(){
    return score;
  }
}
