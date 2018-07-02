using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast1 : MonoBehaviour {

    public GameObject controller, ray, box;
    string condition;
    RaycastHit hit;

    // Use this for initialization
    void Start () {
        ray = GameObject.FindWithTag("ray");
        //box = GameObject.FindWithTag("Interactive");
        //ray_dist = 0.5f;
    }
	
	// Update is called once per frame
	void Update () {
        string cond = onCall();
        if (Physics.Raycast(ray.transform.position, ray.transform.forward, out hit))
        {
            if (hit.transform.tag == "Interactive")
            {
                if ( cond == "C")
                {
                    Debug.Log(" Attach True ");
                    Quaternion rotation = hit.transform.localRotation;
                    Vector3 scale = hit.transform.localScale;

                    hit.transform.SetParent(ray.transform.parent, true);
                }

                if (cond == "H")
                {
                    Debug.Log("Attach False");
                    //Quaternion rotation = hit.transform.localRotation;
                    //Vector3 scale = hit.transform.localScale;

                    hit.transform.parent = null;
                }
                /* Vector3 divisor = scale;
                 divisor.x /= ray.transform.parent.localScale.x;
                 divisor.y /= ray.transform.parent.localScale.y;
                 divisor.z /= ray.transform.parent.localScale.z;
                 hit.transform.localScale = divisor;
                 hit.transform.localRotation = rotation;

                 // Do something with the object that was hit by the raycast.
                 */
                //hit.collider.transform.SetParent(this.transform)
            }
        }
    }
    public string onCall()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            condition = "C";
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            condition = "H";
        }
        return condition;
    }
}
