using UnityEngine;
using System.Collections;

public class OMBullet : Bullet {
    public GameObject piss;
    private Vector3 target;
    void Start()
    {
        player = GameObject.Find("player");
        toPlayer = (player.transform.position - transform.position).normalized;
        rb = GetComponent<Rigidbody2D>();
        target = player.transform.position;
    }
	// Use this for initialization
	void FixedUpdate() { 
        
        ToAPlayer();
    
        }
	
	// Update is called once per frame
	void Update () {
	
	}
    void ToAPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position,target,7f*Time.fixedDeltaTime);
        if (transform.position == target)
        {
            Instantiate(piss,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
