using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crab_Controller : MonoBehaviour
{

    private int count;
    public Text countText;
    public Text winText;
    float moveSpeed = 60;
    float rotationSpeed = 300;
    public float jumpForce;
    Vector3 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
        
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

