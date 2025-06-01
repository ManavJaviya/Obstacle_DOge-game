using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    public float wait = 0;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > wait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }   
    }
}
