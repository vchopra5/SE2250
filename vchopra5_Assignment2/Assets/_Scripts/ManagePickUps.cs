using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ManagePickUps : MonoBehaviour
{

    public GameObject prefab;
    private float radius = 10f;

    public int numberOfObjects = 12;

    private int [] pointValues = { 10, 20, 30 };


    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawn()
    {
        Quaternion rotation = new Quaternion(50, 50, 50, 1);
        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            Vector3 pos = new Vector3(Mathf.Cos(angle), 0.15f, Mathf.Sin(angle)) * radius;
            GameObject g = Instantiate(prefab, pos, rotation) as GameObject;

            Rigidbody rb = g.AddComponent<Rigidbody>();
            rb.useGravity = false;

            Collider c = g.GetComponent<Collider>();
            c.isTrigger = true;

            PickUp p = g.AddComponent<PickUp>();
            Renderer r = g.GetComponent<Renderer>();

            if (i % 3 == 0)
            {
                r.material.color = Color.red;
                p.Score = pointValues[0];
            }
            else if (i % 2 == 0)
            {
                r.material.color = Color.blue;
                p.Score = pointValues[1];
            }
            else
            {
                r.material.color = Color.green;
                p.Score = pointValues[2];
            }


        }
    }
}
