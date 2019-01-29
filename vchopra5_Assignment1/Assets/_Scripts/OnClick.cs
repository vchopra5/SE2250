using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    Vector3 originalPos;
    Vector3 originalRot;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        originalRot = new Vector3(gameObject.transform.rotation.x, gameObject.transform.rotation.y, gameObject.transform.rotation.z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(1))
        {
            gameObject.transform.position = originalPos;
            gameObject.transform.eulerAngles = originalRot;
        }
    }
}
