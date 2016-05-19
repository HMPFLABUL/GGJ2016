using UnityEngine;
using System.Collections;

public class manHospital : Enemy {
   // private bool alllowShoting = false;
    public float BulletShotDelay=2f;
    public AudioSource aud;
	// Use this for initialization
	void Start () {
        aud = GetComponent<AudioSource>();
        waitForNextBullet = new WaitForSeconds(BulletShotDelay);
        if (player == null)
            player = GameObject.Find("player");
        StartCoroutine(WaitRandom());
    }
	
	// Update is called once per frame
	void Update () {
        ShootBullet();
	}

    void ShootBullet()
    {
        if (allowShoting)
        {
            aud.Play();
            Instantiate(bullet, transform.position, Quaternion.identity);
            StartCoroutine(WaitForNextBullet());
        }
    }

   // private IEnumerator WaitForNextBullet()
    //{
    //private EdgeCollider2D edColl;
    //edColl= GetComponent<EdgeCollider2D>;
    //edColl
        // alllowShoting = false;
        // yield return waitForNextBullet;
        // alllowShoting = true;
   // }
    private IEnumerator WaitRandom()
    {
        //private EdgeCollider2D edColl;
        //edColl= GetComponent<EdgeCollider2D>;
        //edColl
        
        yield return new WaitForSeconds(Random.Range(1f,4f));
        allowShoting = true;
    }

}
