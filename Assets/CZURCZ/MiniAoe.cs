using UnityEngine;
using System.Collections;

public class MiniAoe : MonoBehaviour {

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
        yield return new WaitForSeconds(.5f);
        Destroy(gameObject);
    }
}
