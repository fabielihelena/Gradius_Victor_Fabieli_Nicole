using UnityEngine;
using System.Collections;

public class ShootBehaviour : Default {
    public float speed;
	// Use this for initialization
	void Start () {

	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            col.gameObject.GetComponent<Enemy_Behaviour>().life -= 1;
            
        }
        if (col.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "BossEye")
        {
            Destroy(gameObject);
            col.gameObject.GetComponent<BossBehaviour>().life -= 1;
        }
    }

	// Update is called once per frame
	void Update () {
        
        rigidbody.AddRelativeForce(speed  , 0, 0,ForceMode.Impulse);
	}
}
