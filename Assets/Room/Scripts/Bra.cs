using UnityEngine;
using System.Collections;

public class Bra : MonoBehaviour {

    public GameObject player;
    // Use this for initialization
    void Start () {
        player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 dir = player.transform.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
