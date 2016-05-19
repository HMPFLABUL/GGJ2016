using UnityEngine;
using System.Collections;

public class Unicorn : Enemy {

	// Use this for initialization
	void Start () {
        waitForNextBullet = new WaitForSeconds(2f);
        if (player == null)
        {
            player = GameObject.Find("player");
        }
    }
	
	// Update is called once per frame
	void Update () {
        ShotBullet();

    }

    
}
