using UnityEngine;
using System.Collections;

public class Enemy_Behaviour : Default {
    public float speed;
    Transform t;
	// Use this for initialization
	void Start () {
        t = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}

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
	}
}
