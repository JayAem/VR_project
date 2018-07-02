using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translation : MonoBehaviour {
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    // Use this for initialization
    void Start () {
    
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.down, turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.Rotate(- Vector3.down, turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
            transform.Rotate(Vector3.fwd, turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(- Vector3.fwd, turnSpeed * Time.deltaTime);
    }
}
