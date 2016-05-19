using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour {

    public GameObject BAoe;

    // Use this for initialization
    void Start () {
        StartCoroutine(WaitToKill());
    }

    // Update is called once per frame
    void Update () {
	
	}
    IEnumerator WaitToKill()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(BAoe, new Vector3(-0.27f, -6.12f, 0f), Quaternion.identity);
        Destroy(gameObject);
    }
}
