using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int playerSpeed;
    public int score;
    public GameObject ScoreTextObject;
    // Start is called before the first frame update
    void Start()
    {
       this.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
                   transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }

        ScoreTextObject.GetComponent<Text>().text = getScore() ;
    }

    public string getScore()
    {
        return "Score: "+this.score;
    }
}
