using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

    public GameObject _ray;
    Collider col;

    private void Start(){
        _ray = GameObject.FindWithTag("ray");
        _ray.GetComponent<Renderer>().enabled = false;
        col = GetComponent<Collider>();
        col.enabled = false;
    }
    private void Update(){
        
        if (Input.GetKey(KeyCode.Space)){
            _ray.GetComponent<Renderer>().enabled = !_ray.GetComponent<Renderer>().enabled;
            col.GetComponent<Collider>().enabled = !col.GetComponent<Collider>().enabled;
        }
    }
}


        

