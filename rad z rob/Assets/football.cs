using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Football : MonoBehaviour
{
    Rigidbody rb;
        internal void Kick()
    {
        print("Ive been kicked!!");
        rb.AddExplosionForce(500, transform.position + new Vector3(0, -1, -1), 2);

    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            rb.AddExplosionForce(500, transform.position + new Vector3(0, -1, -1), 2);

        }


    }
}
