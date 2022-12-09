using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Check : MonoBehaviour
{   
    public Text scoreText;
    Dance d;
    Timing t;
    public int score;

    public GameObject X0;
    public GameObject X1;

    public GameObject Y0;
    public GameObject Y1;

    public GameObject Z0;
    public GameObject Z1;
    public static int live = 3;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("score"))
        {
            score = PlayerPrefs.GetInt("score");
            scoreText.text = score.ToString();
        }
        else
        {
            PlayerPrefs.SetInt("score",0);
            scoreText.text = PlayerPrefs.GetInt("score").ToString();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        d = FindObjectOfType<Dance>();

        scoreText.text = "Score " + score.ToString();

        

        
       
    }

    void OnCollisionEnter(Collision col)
    {
        
        if(d.isA == true && col.gameObject.tag == "arrowLeft")
        {
            score = score + 1;
            Debug.Log("Good!");
            d.isA = false;
        }
        else
        if(d.isD == true && col.gameObject.tag == "arrowRight")
        {   
            score = score + 1;
            Debug.Log("Good");
            d.isD = false;
        }
        else
        if(d.isS == true && col.gameObject.tag == "arrowDown")
        {
            score = score + 1;
            Debug.Log("Good");
            d.isS = false;
        }
        else
        if(d.isW == true && col.gameObject.tag == "arrowUp")
        {
            score = score + 1;
            Debug.Log("Good");
            d.isW = false;
        }
        else
        {
            score = score - 1;
            live = live - 1;

            if(live == 2)
            {
                GetRed(X0, X1);
            }
            else
            if(live == 1)
            {
                GetRed(Y0, Y1);
            }
            else
            if(live == 0)
            {   
                GetRed(Z0, Z1);
                d.Animator.SetBool("isFail", true);
                Debug.Log("You Failed!");
                PlayerPrefs.SetInt("score",score);
                PlayerPrefs.Save();
            }
            
        }
    }

    void GetRed(GameObject one, GameObject two)
    {
        one.gameObject.GetComponent<Renderer>().material.color = Color.red;
        two.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
