using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.5f, 0, Space.Self);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.name == "Player")
        {
            Points.updatePlayerScore(Score);
            Destroy(gameObject);
        }
    }

    private int score;

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }
}
