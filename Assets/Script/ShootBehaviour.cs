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
            Destroy(col.gameObject);
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Respawn").GetComponent<Respawn>().score += 1;
        }
        if (col.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }

	// Update is called once per frame
	void Update () {

        rigidbody.AddRelativeForce(speed , 0, 0,ForceMode.Force);
	}
}
