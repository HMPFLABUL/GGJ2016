using UnityEngine;
using UnityEngine.SceneManagement;


public class Przejscie : MonoBehaviour {

    private string lvlName;

    // Use this for initialization
    void Start () {
       lvlName = PlayerPrefs.GetString("nextlvl");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D (Collision2D coll)
    {
        SceneManager.LoadScene(lvlName);
    }
}
