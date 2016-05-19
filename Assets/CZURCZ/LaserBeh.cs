using UnityEngine;
using System.Collections;

public class LaserBeh : MonoBehaviour {


	void Start () {
        StartCoroutine(WaitToKill());
	}
	
	void Update () {
	    
	}

    void OnCollisionEnter2D (Collision2D coll)
    {
        Debug.Log("hh");
    }
    IEnumerator WaitToKill()
    {
        yield return new WaitForSeconds(1.6f);
        Destroy(gameObject);
    }

}
