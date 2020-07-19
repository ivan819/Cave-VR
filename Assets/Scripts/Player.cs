using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerSpeed;
    //public int score;
    // Start is called before the first frame update
    void Start()
    {
       // this.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
                   transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }

    }
}
