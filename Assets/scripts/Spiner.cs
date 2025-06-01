using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiner : MonoBehaviour
{
    public int rtspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rtspeed);
    }
}
