using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class deadm8 : MonoBehaviour {

    private bool kill = false;
    private IEnumerator WaitToKill()
    {
        //private EdgeCollider2D edColl;
        //edColl= GetComponent<EdgeCollider2D>;
        //edColl
        kill = false;
        yield return new WaitForSeconds(3f);
        kill = true;

    }
    // Use this for initialization
    void Start()
    {
        StartCoroutine(WaitToKill());
    }

    // Update is called once per frame
    void Update()
    {
        if (kill)
            SceneManager.LoadScene("MENU");

    }
}

