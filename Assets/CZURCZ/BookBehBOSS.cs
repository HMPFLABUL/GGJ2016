using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BookBehBOSS : MonoBehaviour
{

    bool canPickUp = false;
    public GameObject bookPickUpSpace;
    public GameObject altarFinal;
    public GameObject nakladka;
    public GameObject portal;
    public GameObject altarColl;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canPickUp == true && Input.GetKeyDown(KeyCode.Space))
        {
            BookPickUp();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        canPickUp = true;
        bookPickUpSpace.SetActive(true);

    }

    void OnCollisionExit2D(Collision2D collisionInfo)
    {
        canPickUp = false;
        bookPickUpSpace.SetActive(false);

    }

    void BookPickUp()
    {
        portal.SetActive(true);
        bookPickUpSpace.SetActive(false);
        canPickUp = false;
        nakladka.SetActive(true);
        altarFinal.SetActive(true);
        altarColl.SetActive(false);
    }
}
