using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSphere : MonoBehaviour
{
    public float speed;
    private Rigidbody sphere;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);

        sphere.AddForce(movement * speed);
    }
}
