using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayreMovement : MonoBehaviour
{
    public float speed;
    public float horizontalinput;
    public float verticalinput;
    
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        verticalinput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * verticalinput * speed );
        transform.Translate(Vector3.right * Time.deltaTime * horizontalinput * speed);

        if(transform.position.z >= 6.07f){
            transform.position = new Vector3(transform.position.x , transform.position.y , 6.07f);
        }
        if(transform.position.x >= 9.48f){
            transform.position = new Vector3(9.48f , transform.position.y , transform.position.z);
        }
        if(transform.position.z <= -6.07f){
            transform.position = new Vector3(transform.position.x , transform.position.y , -6.07f);
        }
        if(transform.position.x <= -9.48f){
            transform.position = new Vector3(-9.48f , transform.position.y , transform.position.z);
        }


    }
}
