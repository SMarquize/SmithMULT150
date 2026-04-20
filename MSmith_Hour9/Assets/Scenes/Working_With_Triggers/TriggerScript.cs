using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
   
   
      void OnTriggerEnter (Collider other)//called when an odject is in a Trigger
        {
            print(other.gameObject.name + "has entered the cude");
        }
        void OnTriggerStay(Collider other)//called while an object is in a Trigger
        {
            print(other.gameObject.name + "is still in cude");
        }
        void OnTriggerExit(Collider other)// called when an object exits a Trigger
        {
            print(other.gameObject.name + "has left the cude");
        }

}
