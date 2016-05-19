using UnityEngine;
using System.Collections;

public class SpawnMenager : MonoBehaviour {

    public GameObject[] waves;
    private bool allowSpawn = true;
    private int i = 0;
    
   

	// Use this for initialization
	void Start () {

        spawnWave(0,2f);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        spawnWave(i,2f);
        
        
	}
    void spawnWave(int i,float w)
    {
        if (allowSpawn && i < waves.Length)
        {
            waves[i].gameObject.SetActive(true);
            allowSpawn = false;
        }
        if(enemiesDead() && i < waves.Length-1)
            StartCoroutine(WaitForSpawn(new WaitForSeconds(w)));
        

    }

    
    private IEnumerator WaitForSpawn(WaitForSeconds w)
    {
        //private EdgeCollider2D edColl;
        //edColl= GetComponent<EdgeCollider2D>;
        //edColl
        allowSpawn = false;
        //if(i < waves.Length-1)
        i++;
        yield return w;
        allowSpawn = true;
        

    }
    bool enemiesDead()
    {
        if (waves[i].transform.childCount == 0)
            return true;
        else
            return false;
    }
    
}
