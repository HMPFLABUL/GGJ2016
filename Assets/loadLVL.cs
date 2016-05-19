using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadLVL : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void LVLLOAD()
    {
        SceneManager.LoadScene("sis_room");
    }
}
