using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class moveball : MonoBehaviour
{
    public GameObject snowBallCloneTemplate;
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
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newSnowballGO = Instantiate(snowBallCloneTemplate, transform.position + transform.forward + Vector3.up, Quaternion.identity);
            SnowballScript myNewSnowball = newSnowballGO.GetComponent<SnowballScript>();
            myNewSnowball.throwSnowball(transform);
        }
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
            transform.position -= Vector3.back * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, -30 * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
            transform.position -= Vector3.left * Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            transform.position -= Vector3.right * Time.deltaTime;

     


        



        
    }
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);

       
        Football myfootball = collision.gameObject.GetComponent<Football>();
        if (myfootball != null)
        {

            myfootball.Kick();

        }       

    }
}
