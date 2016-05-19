using UnityEngine;
using System.Collections;

public class TRI : MonoBehaviour {
    public int HP = 3;
    public float speed = 1;
    public GameObject boom;
    private bool allowShoting;
    public GameObject bullet;
    private GameObject player;
    private Rigidbody2D rb;
    private Vector3 kierunek;

	// Use this for initialization
	void Start () {
        kierunek = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f),0f).normalized * speed * 10 * Time.fixedDeltaTime;
        player = GameObject.Find("player");
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(WaitForNextBullet());
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        ShotBullet();
        Move();
        //DefMe();
    }

    public void ShotBullet()
    {
        if (allowShoting)
        {
            GameObject bull = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z), Quaternion.identity) as GameObject;
            Vector3 dir = player.transform.position - bull.transform.position;
           // float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
           // bull.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            StartCoroutine(WaitForNextBullet());
        }
    }
    private IEnumerator WaitForNextBullet()
    {
        //private EdgeCollider2D edColl;
        //edColl= GetComponent<EdgeCollider2D>;
        //edColl
        allowShoting = false;
        yield return new WaitForSeconds(4f);
        allowShoting = true;

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ASword")
        {
            if (HP == 0)
            {
                Instantiate(boom, transform.position, Quaternion.identity);
                Instantiate(boom, transform.position + new Vector3(-0.5f, -0.5f, 0), Quaternion.identity);
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
            transform.position = new Vector3(Random.Range(-15f,15f),Random.Range(-35f,35f),0f);
        }

    }
    void Move()
    {
        if (Mathf.Abs(transform.position.x) > 17.5f)
            kierunek.x = -kierunek.x;
        if (Mathf.Abs(transform.position.y) > 38.5f)
            kierunek.y = -kierunek.y;
        rb.transform.Translate(kierunek);

    }
}
