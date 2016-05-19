using UnityEngine;
using System.Collections;

public class FatCoder : Enemy
{
    public float speed = 10f; 
    public GameObject shields;
    public GameObject mouses;
    public GameObject mouses2;
    // Use this for initialization
    //void Start()
    //{

    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        GoToPlayer();
        Rotate(shields, 10f);
        Rotate(mouses, -5f);
        Rotate(mouses2, 3f);

    }

    void GoToPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    void Rotate(GameObject go,float rotateSpeed)
    {
        go.transform.Rotate(0f, 0f, rotateSpeed *10f* Time.fixedDeltaTime);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
       // if (col.gameObject.tag == "ASword")
       // {
         //   Instantiate(boom, transform.position, Quaternion.identity);
         //   Destroy(gameObject);
       // }
        //Debug.Log(col.gameObject.tag);
    }
}