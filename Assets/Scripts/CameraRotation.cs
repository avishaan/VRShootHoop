using UnityEngine;

public class CameraRotation : MonoBehaviour {

  private Camera mainCamera;
  // Use this for initialization
  void Start () {
    print("Parent Transform");
    print(transform);
    print("Camera Transform");
    print(mainCamera);
    mainCamera = GetComponentInChildren<Camera>();
  }

  // Update is called once per frame
  void Update () {
    float rotationSpeed = 2.0f;
    float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
    float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
    transform.localRotation = Quaternion.Euler(0, mouseX, 0) * transform.localRotation;
    mainCamera.transform.localRotation = Quaternion.Euler(-mouseY, 0, 0) * mainCamera.transform.localRotation;
  }
}
