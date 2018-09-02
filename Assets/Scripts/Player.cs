using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody playerRigidbody;

    public float moveSpeed = 0.2f; //to be tuned in unity later
    public float[] clampPos = {
        -8f,    // xMin
        8f,     // xMax
        -8f,    // zMin
        3f,     // zMax
    };


	void Start () {
        playerRigidbody = GetComponent<Rigidbody>();
	}
	
	void Update () {
        updateLocation();
	}

    private void updateLocation()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        //Debug.Log("Horizontal axis: " + horizontal.ToString() + " Vertical axis: " + vertical.ToString());

        float newX = Mathf.Clamp(transform.position.x + (moveSpeed * horizontal), clampPos[0], clampPos[1]);
        float newZ = Mathf.Clamp(transform.position.z + (moveSpeed * vertical), clampPos[2], clampPos[3]);

        Vector3 newPos = new Vector3(newX,
                                     transform.position.y, //locked by rigidbody
                                     newZ);

        playerRigidbody.position = newPos;
    }
}
