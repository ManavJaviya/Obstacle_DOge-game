using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
     int hits = 0;
     void OnCollisionEnter(Collision other)
     {
          if (other.gameObject.tag != "Hit")
          {
               hits++;
               Debug.Log("you hit for this many time :  " + hits);
          }
     }
}
