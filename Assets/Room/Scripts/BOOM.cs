using UnityEngine;
using System.Collections;

public class BOOM : MonoBehaviour {
    private bool kill = false;
    private IEnumerator WaitToKill()
    {
        //private EdgeCollider2D edColl;
        //edColl= GetComponent<EdgeCollider2D>;
        //edColl
        kill = false;
        yield return new WaitForSeconds(1f);
        kill = true;

    }
    // Use this for initialization
    void Start () {
        StartCoroutine(WaitToKill());
	}
	
	// Update is called once per frame
	void Update () {
        if (kill)
            Destroy(gameObject);
	
	}
}
