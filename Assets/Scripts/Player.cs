using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody playerRigidbody;
    private bool facingRight;
    private float horizontal;
    private float vertical;

    public float moveSpeed = 0.2f; //to be tuned in unity later
    public float[] clampPos = {
        -8f,    // xMin
        8f,     // xMax
        -8f,    // zMin
        3f,     // zMax
    };


	void Start () {
        playerRigidbody = GetComponent<Rigidbody>();
        facingRight = true;
	}
	
	void Update () {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        updateLocation();
    }

    private void updateLocation()
    {
        //Debug.Log("Horizontal axis: " + horizontal.ToString() + " Vertical axis: " + vertical.ToString());

        float newX = Mathf.Clamp(transform.position.x + (moveSpeed * horizontal * Time.deltaTime),
                                 clampPos[0],
                                 clampPos[1]);

        float newZ = Mathf.Clamp(transform.position.z + (moveSpeed * vertical * Time.deltaTime),
                                 clampPos[2],
                                 clampPos[3]);

        Vector3 newPos = new Vector3(newX, transform.position.y, newZ);

        playerRigidbody.position = newPos;
    }
}
