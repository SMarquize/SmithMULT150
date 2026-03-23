using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 1;
        while(count<=4)
        {
            Debug.Log(count);
            count++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
