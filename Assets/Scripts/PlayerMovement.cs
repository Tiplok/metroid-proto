using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody rigid;

    public float moveSpeed = 5;
    public float jumpPower = 15;

    void Awake () {
        rigid = this.GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newVelocity = rigid.velocity;

        // Horizontal
        newVelocity.x = Input.GetAxis("Horizontal") * moveSpeed;

        // Vertical
        if (Input.GetKeyDown(KeyCode.Z)){
            newVelocity.y = jumpPower;
        }

        rigid.velocity = newVelocity;
	}
}
