using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -8);
    public Camera cameran;
    public Camera camel;

    // Start is called before the first frame update
    void Start()
    {
        cameran.enabled = false;
        camel.enabled = true;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camera behind the vehicle by adding a new vector3 with the cameras old position.
        transform.position = player.transform.position + offset;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            camel.enabled = false;
            cameran.enabled = true;
        }
        else if(Input.GetKeyDown(KeyCode.E))
        {
            camel.enabled = true;
            cameran.enabled = false;
        }
    }

}
