using UnityEngine;
using System.Collections;

public class Enemy_Behaviour : Default {
<<<<<<< HEAD
    public float speed;
=======
    public float speedz;
    public float speedx;
>>>>>>> origin/master
    Transform t;
	// Use this for initialization
	void Start () {
        t = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}

<<<<<<< HEAD
	// Update is called once per frame
	void Update () {
        t = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if (t.position.z < transform.position.z)
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
        }
        else if (t.position.z > transform.position.z)
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }

        
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
=======
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
            Destroy(col.gameObject);
    }

	// Update is called once per frame
	void Update () {
        t = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if (t.position.z + 1 < transform.position.z )
        {
            transform.position += new Vector3(0, 0, -speedz * Time.deltaTime);
        }
        else if (t.position.z > transform.position.z)
        {
            transform.position += new Vector3(0, 0, speedz * Time.deltaTime);
        }

        
        transform.position += new Vector3(-speedx * Time.deltaTime, 0, 0);
>>>>>>> origin/master
	}
}
