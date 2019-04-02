using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraRayController : MonoBehaviour
{

    public Slider counterSlider;
    public Text infoText;
    public string nextScene;
    float counter = 0;
    public float maxCount;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, direction, out hit, 50))
        {
            //Debug.Log(hit.collider);
            if (hit.collider.CompareTag("InfoHotspot"))
            {
                infoText.enabled = true;
            }
            else if (hit.collider.CompareTag("SceneHotspot"))
            {
                counterSlider.gameObject.SetActive(true);
                counter += Time.deltaTime;
                counterSlider.value = counter / maxCount;
                // change scene
                if (counter > maxCount)
                {
                    SceneManager.LoadScene(nextScene);
                }
            }

        }
        else
        {
            infoText.enabled = false;
            counterSlider.gameObject.SetActive(false);
            counter = 0;
        }
    }
}
