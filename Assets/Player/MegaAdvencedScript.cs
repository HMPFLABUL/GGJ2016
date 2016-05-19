using UnityEngine;
using System.Collections;

public class MegaAdvencedScript : MonoBehaviour {

    bool allowMouseFallow = true;
    public AudioSource[] swordAttack = new AudioSource[2];
    public bool swordAttackChose = true;
    public Player playerScript;
    [SerializeField]
    private PolygonCollider2D edColl;
    //public float radiusOfAttack;
    public GameObject sword;
    private WaitForSeconds waitForAttackEnd = new WaitForSeconds(0.7f);

    void Start()
    {
        //swordAttack[0] = GetComponent<AudioSource>();
        edColl = sword.GetComponent<PolygonCollider2D>();
    }
	
	// Update is called once per frame
	void Update () {
        Attack();
        AdvencedStuff();
    }

    void AdvencedStuff()
    {
        if (allowMouseFallow == true)
        {
            if (playerScript.flipOn == false)
            {
                Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                diff.Normalize();

                float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 220);
            }
            else
            {
                Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                diff.Normalize();

                float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0f, 0f, -(rot_z + 50));
            }
        }
    }

    void MoreAdvanceStuff()
    {
        if (Input.GetMouseButtonDown(1))
        {
            
            StartCoroutine(WaitForAttack());
        }
    }

    private IEnumerator WaitForAttack()
    {
        //private EdgeCollider2D edColl;
        //edColl= GetComponent<EdgeCollider2D>;
        //edColl
        allowMouseFallow = false;
        edColl.enabled = true;
        sword.tag = "ASword";
        yield return waitForAttackEnd;
        sword.tag = "Sword";
        edColl.enabled = false;
        allowMouseFallow = true;
    }

    void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // allowMouseFallow = false;
            // edColl.enabled = true
            if (swordAttackChose)
            {
                swordAttack[0].Play();
                swordAttackChose = !swordAttackChose;
            }
            else
            {
                swordAttack[1].Play();
                swordAttackChose = !swordAttackChose;
            }

            StartCoroutine(WaitForAttack());
            //edColl.enabled = !edColl.enabled;
            //allowMouseFallow = true;

            //Debug.Log("hit");

        }
    }

}
