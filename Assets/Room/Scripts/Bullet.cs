using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public GameObject player;
    public float speed;
    protected Vector2 toPlayer;
    protected Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("player");
        toPlayer = (player.transform.position- transform.position).normalized;
        rb = GetComponent<Rigidbody2D>();
        GoToPlayer();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
        if (transform.position == new Vector3(toPlayer.x,toPlayer.y,transform.position.z))
            Destroy(gameObject);
        
	
	}
    public void GoToPlayer()
    {
        rb.AddForce(toPlayer*speed);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Walls" || col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        
    }

}
