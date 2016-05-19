using UnityEngine;
using System.Collections;



public class Bear : Enemy {

    //public GameObject player;
    public float speed;
    private AudioSource aud;

	// Use this for initialization
	void Start () {
        aud = GetComponent<AudioSource>();
        //transform.localScale = new Vector3(0.1f, 0.1f, 1f);
        if (player == null)
        {
            player = GameObject.Find("player");
        }
    }
	
	// Update is called once per frame
	void Update () {
        GoToPlayer();
        //ScaleUp();
    }

    void GoToPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            aud.Play();
        }
    }
}
