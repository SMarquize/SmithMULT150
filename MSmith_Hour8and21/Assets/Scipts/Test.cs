using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        double Health = 100;
        Health = TakeDamage(Health, 20);

        double TakeDamage(double Health, double Damage)
        {
            return Health - Damage;
        }
        print(Health);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
