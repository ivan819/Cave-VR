using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coinCollision : MonoBehaviour
{
    public Player playerScript;
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("trigger");
        if(col.gameObject.name == "Coin")
        {
            Destroy(col.gameObject);
            int score = ++playerScript.GetComponent<Player>().score;
            Debug.Log("score");

            

        }


        

    }
}
