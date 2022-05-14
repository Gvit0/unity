using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotCam : MonoBehaviour
{   
    float xRot;
    float yRot;
    public GameObject cam;
    public GameObject GamObj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xRot += Input.GetAxis("Mouse X");
        yRot += Input.GetAxis("Mouse Y");
        cam.transform.rotation = Quaternion.Euler(-yRot / 3 * sensitivity, 0f, 0f);
        GamObj.transform.rotation = Quaternion.Euler(0f, xRot / 3 * sensitivity, 0f);
    }
}
