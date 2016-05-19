using UnityEngine;
using System.Collections;

public class LadyHospital : Enemy {

    public GameObject Cane;
    private float rotateSpeed = 30f;
    private float speed = 15f;
    // Use this for initialization
    //void Start () {

    //}

    // Update is called once per frame
    void FixedUpdate() {
        CaneRotate();
        GoToPlayer();
    }
    void CaneRotate()
    {
        Cane.transform.Rotate(0f, 0f, rotateSpeed * 10f * Time.deltaTime);
    }
    void GoToPlayer()
    {
        Vector2 toPlayer = (player.transform.position - transform.position).normalized;
        GetComponent<Rigidbody2D>().AddForce(toPlayer*speed*Time.fixedDeltaTime);
    }
}
