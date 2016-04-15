using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {
  public GameObject ballPrefab;
  public float velocity = 1.0f;

  // Use this for initialization
  void Start () {
  }

  // Update is called once per frame
  void Update () {
    if (Input.GetKeyDown(KeyCode.LeftArrow)){
      GameObject instance = Instantiate(ballPrefab);
      Rigidbody rb = instance.GetComponent<Rigidbody>();
      rb.velocity = Vector3.left * velocity;
    }
    else if(Input.GetKeyDown(KeyCode.RightArrow)){
      GameObject instance = Instantiate(ballPrefab);
      Rigidbody rb = instance.GetComponent<Rigidbody>();
      rb.velocity = Vector3.left * velocity;
    }
    else if(Input.GetButtonDown("Fire1")){
      GameObject instance = Instantiate(ballPrefab);
      instance.transform.position = transform.position;
      Rigidbody rb = instance.GetComponent<Rigidbody>();
      rb.velocity = Vector3.forward * velocity;
    }
    else if(Input.GetKeyDown(KeyCode.DownArrow)){
      GameObject instance = Instantiate(ballPrefab);
      Rigidbody rb = instance.GetComponent<Rigidbody>();
      rb.velocity = Vector3.back * velocity;
    }
  }
}
