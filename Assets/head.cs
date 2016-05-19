using UnityEngine;
using System.Collections;

public class head : MonoBehaviour {

    public GameObject parent;
    public GameObject boom;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ASword")
        {
            Instantiate(boom, transform.position, Quaternion.identity);
            Destroy(parent);
        }
        //Debug.Log(col.gameObject.tag);
    }
}
