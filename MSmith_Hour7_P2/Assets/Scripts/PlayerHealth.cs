using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //get the sum of all numders from 0 to 1004
        float heath = 1004f;
        float poisonDamage = 125.5f;
        Debug.Log(heath);
        heath =heath-=poisonDamage;
        Debug.Log(heath);
        while (heath>=0)
        {
            Debug.Log("heath:" + heath + "poisonDamage:" + poisonDamage);
            heath=heath -= poisonDamage;//heath -= poisonDamage
        }
        Debug.Log(heath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
