using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int HealthPoint = 3992;
        HealthPoint = UsePotion(HealthPoint);
        HealthPoint = UsePotion(HealthPoint);
        HealthPoint = UsePotion(HealthPoint);
        HealthPoint = UsePotion(HealthPoint);
        int UsePotion(int Health)
        {
            Health = 400;
            return Health+ HealthPoint;
        }
        print(HealthPoint);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
