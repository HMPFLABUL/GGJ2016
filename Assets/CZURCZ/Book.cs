using UnityEngine;
using System.Collections;

public class Book: MonoBehaviour {

    float bookScaleSpeed = 8;
    Vector3 scale;
    Vector3 scale1;
    bool scaleOn = true;
    public Door doorScript;
    public GameObject collD;

    void Start () {
        collD = GameObject.Find("Collider Drzwi");
        scale1 = new Vector3(1.25F, 1.25F, 1);
        scale = new Vector3(1.25f, 1.25f, 1);
        doorScript = collD.GetComponent<Door>();
        doorScript.canLeave = true;
        
	}
	
	void Update () {
        if(scaleOn==true)
            BookScale();
        Close();
    }


    void BookScale()
    {
        transform.localScale = Vector3.Lerp(gameObject.transform.localScale, scale, Time.deltaTime* bookScaleSpeed);
        if (transform.localScale.x >= scale1.x && transform.localScale.y >= scale1.y)
            scaleOn = false;
    }

    void Close()
    {
        if (Input.GetKeyDown("space"))
        {
            Destroy(gameObject);
        }
    }
}
