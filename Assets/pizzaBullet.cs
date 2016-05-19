using UnityEngine;
using System.Collections;

public class pizzaBullet : MonoBehaviour {
    private Vector2 kierunek;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 startPos;
	// Use this for initialization
	void Start () {
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        kierunek = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized * speed * 10 * Time.fixedDeltaTime;
    }
	
	// Update is called once per frame
	void Update () {
        Move();
	}
    void Move()
    {
        if (Mathf.Abs(transform.position.x) > 18f)
            kierunek.x = -kierunek.x;
        if (Mathf.Abs(transform.position.y) > 40f)
            kierunek.y = -kierunek.y;
        rb.transform.Translate(kierunek);

    }
}
