using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      for(int day=1; day<=30; day++)
        {
            Debug.Log(day);
            if(day==8)
            {
                Debug.Log("My Birthday");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
