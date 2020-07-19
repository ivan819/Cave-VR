using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("trigger");
        if(col.gameObject.name == "Coin")
        {
            Destroy(col.gameObject);
        }
      
    }
}
