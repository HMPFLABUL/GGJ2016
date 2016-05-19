using UnityEngine;
using System.Collections;

public class MB_Sis : MonoBehaviour {

    public GameObject bullet;
    [SerializeField]
    private int HP;
   // [SerializeField]
    private GameObject player;
    public GameObject boom;

    public GameObject bra;
    private WaitForSeconds  shotWait;
    private bool allowShoting = true;
    // Use this for initialization
    void Start () {
        player = GameObject.Find("player");
        shotWait = new WaitForSeconds(2f);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        ShotBullet();
        DefMe();
	}

    public void ShotBullet()
    {
        if (allowShoting)
        {
            GameObject bull = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y-1f, transform.position.z), Quaternion.identity) as GameObject;
            Vector3 dir = player.transform.position - bull.transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            bull.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            StartCoroutine(WaitForNextBullet());
        }
    }
    private IEnumerator WaitForNextBullet()
    {
        //private EdgeCollider2D edColl;
        //edColl= GetComponent<EdgeCollider2D>;
        //edColl
        allowShoting = false;
        yield return shotWait;
        allowShoting = true;

    }
    private void DefMe()
    {
        if(player.transform.position.y>0 && Mathf.Abs(player.transform.position.x) < transform.position.x+3)
        {
            bra.gameObject.SetActive(true);
        }
        else bra.gameObject.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "BossKill")
        {
            if (HP == 0)
            {
                Instantiate(boom, transform.position, Quaternion.identity);
                Instantiate(boom, transform.position+new Vector3(-0.5f,-0.5f,0), Quaternion.identity);
                Instantiate(boom, transform.position + new Vector3(0.5f, 0.5f, 0), Quaternion.identity);
                Instantiate(boom, transform.position + new Vector3(-0.5f, 0.5f, 0), Quaternion.identity);
                Instantiate(boom, transform.position + new Vector3(0.5f, -0.5f, 0), Quaternion.identity);
                Instantiate(boom, transform.position + new Vector3(0.5f, 0f, 0), Quaternion.identity);
                Instantiate(boom, transform.position + new Vector3(-0.5f, 0f, 0), Quaternion.identity);
                Instantiate(boom, transform.position + new Vector3(0f, -0.5f, 0), Quaternion.identity);
                Instantiate(boom, transform.position + new Vector3(0f, 0.5f, 0), Quaternion.identity);
                Destroy(gameObject);
            }
            else
                HP--;
        }

    }


}
