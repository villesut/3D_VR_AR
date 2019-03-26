using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_Controller : MonoBehaviour
{


    float moveSpeed = 100;
    float rotationSpeed = 300;
    public float jumpForce;
    Vector3 originalPos;
   // Vector3 originalRot;

    // Start is called before the first frame update
    void Start()
    {
        //originalPos = new Vector3(gameObject.transform.position.x, 20f, gameObject.transform.position.z);
       // originalRot = new Vector3(gameObject.transform.rotation.x, gameObject.transform.rotation.y, gameObject.transform.rotation.z);
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float zMovement = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(xMovement, 0f, zMovement) * moveSpeed * Time.deltaTime);

        float yRotation = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, yRotation * Time.deltaTime * rotationSpeed, 0));
      

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
        }
        
       /* if (Input.GetButtonDown("Fire1"))
        {
            gameObject.transform.position = originalPos;
            gameObject.transform.Rotate(new Vector3(0,0,0));
        }*/
    }
}
