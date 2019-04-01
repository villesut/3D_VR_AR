using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Done by the unity tutorial 

public class Crab_Controller : MonoBehaviour
{

    private int count;
    public Text countText;
    public Text winText;
    float moveSpeed = 60;
    float rotationSpeed = 300;
    float jumpForce = 400;
    Vector3 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
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
     
        
     
    }
    //pick up
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {

            other.gameObject.SetActive(false);
            count = count + 1; //count++
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 14)
        {
            winText.text = "You Win!";
        }
    }
}

