﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject sphere;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - sphere.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = sphere.transform.position + offset;
    }
}
