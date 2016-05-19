using UnityEngine;
using System.Collections;

public class BigAoe : MonoBehaviour {

    void Start()
    {
        StartCoroutine(WaitToKill());
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("hh");
    }
    IEnumerator WaitToKill()
    {
        yield return new WaitForSeconds(0.9f);
        Destroy(gameObject);
    }
}
