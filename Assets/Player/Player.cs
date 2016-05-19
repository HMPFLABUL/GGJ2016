using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float speed = 10;
    public AudioSource deadSound;
    public AudioSource hitSound;
    public GameObject deadme;
    public int HP=5;
    public string lvlName;
    public Rigidbody2D rb;
    public bool flipOn = false;
    public float playerScale;
    public GameObject arm;
    private bool allowMove = true;


    void Start () {
        rb = GetComponent<Rigidbody2D>();
	 }
	
	void FixedUpdate () {
        Movement();
	
	}
    void Movement()
    {
        if (allowMove)
        {
            //public float tilt;
            //public Boundary boundary;
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb.velocity = movement * speed;

            if (moveHorizontal != 0)
            {
                if (rb.velocity.x < 0)
                {
                    flipOn = true;
                    Vector3 ls = new Vector3(-playerScale, playerScale, 1);
                    transform.localScale = ls;
                }
                else
                {
                    flipOn = false;
                    Vector3 ls = new Vector3(playerScale, playerScale, 1);
                    transform.localScale = ls;
                }
            }
        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            hitSound.Play();
            HP -= 1;
            if (HP == 0)
            {
                DestroyAndDie(arm);
            }
            //if (col.gameObject.tag == "Bullet")
            //{
              //  HP -= 1;
               // if (HP == 0)
               // {
                 //   DestroyAndDie(arm);

                //}
            //}
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            hitSound.Play();
            HP -= 1;
            if (HP == 0)
            {
                DestroyAndDie(arm);
            }
        }
        if (col.gameObject.tag == "Item")
        {
            SceneManager.LoadScene(lvlName);
            Debug.Log("h");

        }
    }
    void DestroyAndDie(GameObject a)
    {
        deadSound.Play();
        allowMove = false;
        rb.velocity = Vector2.zero;
        gameObject.layer = 9;
        Instantiate(deadme, transform.position, Quaternion.identity);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        a.GetComponent<SpriteRenderer>().enabled = false;
    }
}
