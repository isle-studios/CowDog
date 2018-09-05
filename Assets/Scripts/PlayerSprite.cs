using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite : MonoBehaviour {

    private float horizontal;
    private float vertical;
    private bool facingRight;

	void Update () {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        updateScale();
    }

    private void updateScale()
    {
        if (horizontal < 0)
        {
            facingRight = false;
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * -1,
                                               transform.localScale.y,
                                               transform.localScale.z);
        }
        else if (horizontal > 0)
        {
            facingRight = true;
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x),
                                               transform.localScale.y,
                                               transform.localScale.z);
        }
    }
}
