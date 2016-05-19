using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BookBeh : MonoBehaviour {

    bool canPickUp = false;
    public GameObject bookPickUpSpace;
    public GameObject bookInwestory;
    public Camera main;
   

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (canPickUp == true && Input.GetKeyDown(KeyCode.Space))
        {
            BookPickUp();
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        canPickUp = true;
        bookPickUpSpace.SetActive (true);

    }

    void OnCollisionExit2D(Collision2D collisionInfo)
    {
        canPickUp = false;
        bookPickUpSpace.SetActive (false);

    }

    void BookPickUp()
    {
        bookPickUpSpace.SetActive(false);
        canPickUp = false;
        Vector3 cameraPoz = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0);
        GameObject bookk = Instantiate(bookInwestory, cameraPoz, Quaternion.identity) as GameObject;
        bookk.transform.SetParent(main.transform);
    }
}
