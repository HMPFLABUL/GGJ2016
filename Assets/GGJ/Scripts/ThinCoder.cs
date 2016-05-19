using UnityEngine;
using System.Collections;

public class ThinCoder : Enemy {

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	void Update () {
        if (allowShoting)
        {
            GameObject bull = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            StartCoroutine(WaitForNextBullet());
        }

    }
}
