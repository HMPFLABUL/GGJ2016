using UnityEngine;
using System.Collections;

public class ChurchCameraBeh : MonoBehaviour {

    public Transform playerPosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 playerPoz = new Vector3(transform.position.x, playerPosition.position.y, transform.position.z);
        transform.position = playerPoz;
	}
    
    
}
