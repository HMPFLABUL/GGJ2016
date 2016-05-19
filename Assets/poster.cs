using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class poster : MonoBehaviour {
    private bool allow=true;
    private bool swch = true;
    //public string lvlName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (allow)
        {
            if (swch) 
                transform.localScale=new Vector3(1.55f, 1.55f, 1f); 
            else
                transform.localScale=new Vector3(1.5f, 1.5f, 1f);
            StartCoroutine(Wait());
            swch = !swch;
        }
	
	}
    protected IEnumerator Wait()
    {
        //private EdgeCollider2D edColl;
        //edColl= GetComponent<EdgeCollider2D>;
        //edColl
        allow = !allow;
        yield return new WaitForSeconds(0.3f);
        allow = !allow;

    }
    /*void OnTrigerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(lvlName);

        }
    }*/
}
