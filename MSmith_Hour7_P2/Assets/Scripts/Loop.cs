using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int total = 0;
        int count = 1;
        while(count<=4)
        {
            total = total + count;
            count++;
        }
        
        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
