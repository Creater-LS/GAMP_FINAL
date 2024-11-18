using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float lookSpeed = 2f;

    //public Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(moveX, 0, moveZ);
    }
}
