using UnityEngine;
using System.Collections;

public class bumerang : Bullet {
   // bool sficz = true;
    public float duration = 50; // in seconds

    private Vector3 beginPoint;
    private Vector3 finalPoint;
    private Vector3 farPoint;
    private Rigidbody2D rbb;

    //public bool startAgain = false;

    private float startTime;

    void Start()
    {
        player = GameObject.Find("player");
        rbb = GetComponent<Rigidbody2D>();
        beginPoint = transform.position;
        finalPoint = player.transform.position;
        farPoint = new Vector3(0.1f,0.1f,0f);
        player = GameObject.Find("player");
        toPlayer = (player.transform.position - transform.position);
        //rb = GetComponent<Rigidbody2D>();
        startTime = Time.time;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 500f * Time.deltaTime));
        //Fly();
        StartCoroutine(Throw(toPlayer.magnitude / 2, Random.Range(toPlayer.magnitude/3, toPlayer.magnitude), toPlayer.normalized, toPlayer.magnitude));

        
    }


// Use this for initialization// Update is called once per frame
	void FixedUpdate () {
        //Fly();
    }

    //'dist' - distance of the throw.
 //'width' - width of the ellipse for the throw.
 //'direction' - vector indicating the direction of the throw
 //'time' - time the throw should take.
    IEnumerator Throw(float dist, float width, Vector3 direction, float time)
    {
        Vector3 pos = transform.position;
        float height = transform.position.y;
        Quaternion q = Quaternion.FromToRotation(Vector3.forward, direction);
        float timer = 0.0f;
        rbb.AddTorque(400f);// 0.0f, 400.0f, 0.0f);
        while (timer < time)
        {
            float t = Mathf.PI * 2.0f * timer / time - Mathf.PI / 2.0f;
            float x = width * Mathf.Cos(t);
            float z = dist * Mathf.Sin(t);
            Vector3 v = new Vector3(x, height, z + dist);
            rbb.MovePosition(pos + (q * v));
            timer += Time.deltaTime;
            yield return null;
        }

        Destroy(gameObject);
    }


}
