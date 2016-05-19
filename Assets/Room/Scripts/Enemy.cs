using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public GameObject bullet;
    public GameObject player;
    public float waitTime=5f;
    //public float finalScale;
    protected WaitForSeconds waitForNextBullet;
    protected bool allowShoting = true;
    public GameObject boom;
    // Use this for initialization
    void Start () {
        //transform.localScale= new Vector3(0.1f, 0.1f, 1f);
        waitForNextBullet = new WaitForSeconds(waitTime);
        if(player==null)
            player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update () {
       // ScaleUp();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ASword")
        {
         Instantiate(boom, transform.position, Quaternion.identity);
        Destroy(gameObject);
         }
        //Debug.Log(col.gameObject.tag);
    }

    public void ShotBullet()
    {
        if (allowShoting)
        {
            GameObject bull = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;          
            Vector3 dir = player.transform.position - bull.transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            bull.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            StartCoroutine(WaitForNextBullet());
        }
    }
    protected IEnumerator WaitForNextBullet()
    {
        //private EdgeCollider2D edColl;
        //edColl= GetComponent<EdgeCollider2D>;
        //edColl
        allowShoting = false;
        yield return waitForNextBullet;
        allowShoting = true;

    }
    
   

    //bull =

}

