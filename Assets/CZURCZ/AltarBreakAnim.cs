using UnityEngine;
using System.Collections;

public class AltarBreakAnim : MonoBehaviour {

    public Animator anim;
    public GameObject oldAltar;

	void Start () {
        anim = GetComponent<Animator>();
        anim.SetBool("start", true);
        oldAltar.SetActive(false);
	}
	
	void Update () {
	
	}
}
