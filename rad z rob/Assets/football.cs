using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Football : MonoBehaviour
{
    Rigidbody rb;
        internal void Kick()
    {


        print("Ive been Kicked!!");
        rb.AddExplosionForce(50000,
            transform.position + new Vector3(0,-1,0), 2);

    }
    // Start is called before the first frame update
    void Start()
    {
      


    }

    // Update is called once per frame
    void Update()
    {
  


    }
}
