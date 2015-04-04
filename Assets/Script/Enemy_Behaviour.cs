using UnityEngine;
using System.Collections;

public class Enemy_Behaviour : Default {

    public float speed;
    public float speedz;
    public float speedx;
    public int life = 2;
    Transform t;
	// Use this for initialization
	void Start () {
        t = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            col.gameObject.GetComponent<GradiusBehaviour>().hp -= 1;
        }
            
    }
    
	// Update is called once per frame
    void Update()
    {
        rigidbody.velocity = Vector3.zero;
        t = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if (t.position.z + 1 < transform.position.z)
        {
            transform.position += new Vector3(0, 0, -speedz * Time.deltaTime);
        }
        else if (t.position.z > transform.position.z)
        {
            transform.position += new Vector3(0, 0, speedz * Time.deltaTime);
        }

        if(life <= 0)
        {
            Destroy(gameObject);
        }

        transform.position += new Vector3(-speedx * Time.deltaTime, 0, 0);

    }
}
