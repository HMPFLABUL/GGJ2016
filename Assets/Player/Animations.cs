using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {

    public Animator anim;
    float data, data2;


    void Start() {
        anim = GetComponent<Animator>();
    }

    void Update() {
        
        data = Mathf.Abs(Input.GetAxis("Vertical"));
        data2 = Mathf.Abs(Input.GetAxis("Horizontal"));

        if (data > 0.1f)
        {
            anim.SetBool("move", true);
        }
        else
        {
            if (data2 > 0.1f)
            {
                anim.SetBool("move", true);
            }
            else
                anim.SetBool("move", false);

        }
    }
}

