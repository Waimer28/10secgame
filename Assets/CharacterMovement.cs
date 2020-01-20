using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMovement : MonoBehaviour
{
    public float speed;

    public float timeLeft = 3.0f;

    public Text Timers;

    public Text winText;

    private bool game = false;

    private bool Time2 = false;

    private bool game2 = false;

   public Text scoreText;

    private int score;

    public Text loseText;


    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        winText.text = "";

        score = 0;
        SetScoreText();
        scoreText.text = "Score: " + score.ToString();

        loseText.text = "";
    }
    private void Update()
    {
        timeLeft -= Time.deltaTime;
        Timers.text = (timeLeft).ToString("0");

        if (timeLeft < 0)
        {
            timeLeft = 0;

            Time2 = true;
        }
    }
  
    
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);


        rb2d.AddForce(movement * speed);
        if (Input.GetKey("escape"))
            Application.Quit();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)

    {

        if (collision.collider.tag == "pickups")

        {
            score = score + 1;
            SetScoreText();
            scoreText.text = "score: " + score.ToString();

            Destroy(collision.collider.gameObject);

        }
        if (collision.collider.tag == "Ground")

        {

            if (Input.GetKey(KeyCode.W))



            {

                rb2d.AddForce(new Vector2(0, 3), ForceMode2D.Impulse);

            }
        }
    }
    void SetScoreText()
    {

        scoreText.text = "Score: " + score.ToString();
        if (score > 8)
        {
         game2 = true;
        }


        if (score <= 8 && Time2 == false)
        {
            game = true;
        }

        if (game == true && Time2 == true)
        {
            loseText.text = "You Lost!";

            
        }

        if (game2 ==true && Time2 == false)
        {
            winText.text = "You Win!";
            Time.timeScale = 0;
        }


    }
}
