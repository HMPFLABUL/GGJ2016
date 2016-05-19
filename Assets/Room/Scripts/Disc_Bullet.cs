using UnityEngine;
using System.Collections;

public class Disc_Bullet : Bullet {

    //public GameObject player;
    //public float speed;
    // private Vector2 toPlayer;
    //private Rigidbody2D rb;
    // Use this for initialization
    /*void Start () {
        player = GameObject.Find("player");
        toPlayer = (player.transform.position - transform.position).normalized;
        rb = GetComponent<Rigidbody2D>();
        if(rb!=null)
        GoToPlayer();

    }*/

    // Update is called once per frame
    //private bool allowKillBoss=false;
	void Update () {
        transform.Rotate(new Vector3(0f, 0f, 10f));
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ASword")
        {
            // allowKillBoss = true;
            gameObject.tag = "BossKill";
            rb.AddForce(-2 * toPlayer * speed);
           
        }
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);

        }
        if (col.gameObject.tag == "Boss")
        {
            Destroy(gameObject);

        }

    }
}
