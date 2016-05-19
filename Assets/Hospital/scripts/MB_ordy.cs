using UnityEngine;
using System.Collections;

public class MB_ordy : MonoBehaviour {
    private float rotateSpeed = 5;
    public Transform MB;
    public GameObject par;
    public GameObject boom;
    public int HP;
    // Use this for initialization
    void Start () {
       // MB = GetComponentInChildren<Transform>();
       // MB = MB.GetComponentInChildren<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        RotateC();
        RotateC(MB);
    }
    void RotateC()
    {
        transform.Rotate(0f, 0f, rotateSpeed * -20f * Time.deltaTime);
    }
    void RotateC(Transform t)
    {
        t.Rotate(0f, 0f, rotateSpeed * 10f * Time.deltaTime);
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
                Destroy(par);
                //Destroy(gameObject);
            }
            else
            {
                MB.Rotate(0f, 0f, 180f );
                HP--;
            }
        }
        //Debug.Log(col.gameObject.tag);
    }
}
