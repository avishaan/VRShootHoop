﻿using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

  // Use this for initialization
  void Start () {
  }

  // Update is called once per frame
  void Update () {
    transform.rotation = Quaternion.Euler(0, 1, 0) * transform.rotation;
  }
}