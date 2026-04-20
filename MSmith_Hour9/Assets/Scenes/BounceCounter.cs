using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter (Collider other)//called when an odject enters a Trigger
    {
        print(other.gameObject.name + "enter the cude");
    }
    private void OnTriggerStay (Collider other)// called while an object is in Trigger
    {
        print(other.gameObject.name + "is in the cude");
    }
    private void OnTriggerExit(Collider other)// called when an object exits a Trigger
    {
        print(other.gameObject.name + "exited the cude");
    }
}
