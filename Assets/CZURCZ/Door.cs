using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

    public GameObject doorSpace;
    public bool canLeave = false;
    public string lvlName;

    void Start () {
	
	}

    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (canLeave == true)
        { 
            doorSpace.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(lvlName);
            }
        }
    }

    void OnCollisionExit2D(Collision2D collisionInfo)
    {
        doorSpace.SetActive(false);
    }
}
