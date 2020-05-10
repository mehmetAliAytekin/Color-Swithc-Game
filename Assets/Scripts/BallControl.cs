using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float bounceForce;
    private int colorNum;
    public Text ScoreText;
    public static int score;
    public GameObject circle;
    
    private void Awake()
    {
        setRandomColor();
        ScoreText.text = score.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody2D.velocity = Vector2.up * bounceForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "IncreaseScore")
        {
            score+=50;
            ScoreText.text = score.ToString();
            Instantiate(circle, new Vector3(transform.position.x,
                transform.position.y + 12f, transform.position.z),Quaternion.identity);
            Destroy(other.gameObject);
        }
        
        if (CircleColor.getColorName(colorNum) != other.tag 
            && other.tag != "IncreaseScore")
        {
            Debug.Log("destroy ball");
            //Destroy(gameObject);
            score=0;
            ScoreText.text = score.ToString();
            SceneManager.LoadScene("SampleScene");
        }
        else
            setRandomColor();
    }

    private void setRandomColor()
    {
        colorNum = CircleColor.getRandomColor();
        Color color = CircleColor.getColor(colorNum);

        GetComponent<SpriteRenderer>().color = color;
    }
}