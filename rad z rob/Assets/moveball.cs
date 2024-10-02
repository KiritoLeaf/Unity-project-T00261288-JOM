using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveball : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
            print("could not find aninmator component");
        else
            print("animator component found");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime;
            animator.SetBool("isRunning", true);
        
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("isRunning", false);
        }
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, 30* Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.position -= Vector3.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, -30 * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
            transform.position -= Vector3.left * Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            transform.position -= Vector3.right * Time.deltaTime;
        
    }
}
