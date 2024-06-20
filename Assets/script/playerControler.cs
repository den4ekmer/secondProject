using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    public int speed = 20;

    void Start()
    {
        
    }

    // Update is calle
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
