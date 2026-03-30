using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int TakeDamageFromFireball(int damage, int playerHealth)
        {
            return playerHealth - damage;
        }
        int z = TakeDamageFromFireball(30, 50);
        print("Player health: " + z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
