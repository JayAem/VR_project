using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCollision : MonoBehaviour {
   // bool Pressed, unPressed = false;

    public GameObject controller, ray, box;
    //bool pressed, unPressed = false;
    string cond;

    private void Update()
    {
        controller = GameObject.FindWithTag("GameController");
        box = GameObject.FindWithTag("Interactive");
        cond = onCall();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interactive")
        {
            Debug.Log(" On Trigger Method ");
            if (cond == "true")
            {
                GrabObject(other);
            }
            if (cond == "false")
            {
                ReleaseObject(other);
            }
        }
    }


    private void GrabObject(Collider col)
    {
        Debug.Log(" On Grab Object Method ");
        box.transform.SetParent(this.transform);

        //col.transform.position = this.transform.position;

        //var joint = AddFixedJoint();
        //joint.connectedBody = col.GetComponent<Rigidbody>();
    }

    private void ReleaseObject(Collider _col)
    {
        //box.transform.SetParent(this.transform, false);
        Debug.Log("Release object");
    }

    public string onCall()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cond = "true";
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            cond = "false";
        }
        return cond;
    }

    /*private FixedJoint AddFixedJoint()
    {
        FixedJoint fx = gameObject.AddComponent<FixedJoint>();
        fx.transform.position = box.transform.position;
        //fx.breakForce = 200;
        //fx.breakTorque = 200;
        return fx;
    }*/

}
