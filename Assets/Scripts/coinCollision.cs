using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollision : MonoBehaviour
{
    public Player playerScript;
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("trigger");
        if(col.gameObject.name == "Coin")
        {
            Destroy(col.gameObject);
        }
        playerScript.GetComponent<Player>().score++;

    }
}
