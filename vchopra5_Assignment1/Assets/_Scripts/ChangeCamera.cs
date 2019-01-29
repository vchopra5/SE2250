using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    Camera cam1;
    Camera camMain;
     
     void Start() {
        cam1 = gameObject.GetComponent<Camera>();
        camMain = Camera.main;
        camMain.enabled = true;
        cam1.enabled = false;
     }
     
     void Update() {
         if (Input.GetKeyDown(KeyCode.C)) {
             cam1.enabled = !cam1.enabled;
             camMain.enabled = !camMain.enabled;
         }
     }
}
