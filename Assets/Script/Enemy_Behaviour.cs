using UnityEngine;
using System.Collections;
using System;

public class Enemy_Behaviour : Default {

    public float speed;
    public float speedz;
    public float speedx;
    public int life = 2;
    Transform t;
    public bool isFollowing = false;
	// Use this for initialization
	void Start () {
        try
        {
            t = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }
        catch (NullReferenceException r)
        {

        }
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<GradiusBehaviour>().hp -= 1;
            Destroy(gameObject);
            
        }
        if (col.gameObject.tag == "Finish")
        {
            Destroy(gameObject);

        }
            
    }
    
	// Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            t = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            if (t.position.z + 0.2f < transform.position.z)
            {
                transform.position += new Vector3(0, 0, -speedz * Time.deltaTime);
            }
            else if (t.position.z > transform.position.z + 0.2f)
            {
                transform.position += new Vector3(0, 0, speedz * Time.deltaTime);
            }
        }
        else
        {
            transform.Rotate(0, 0, -2f);
        }

        if(life <= 0)
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Respawn").GetComponent<Respawn>().score += 1;
        }

        transform.position += new Vector3(-speedx * Time.deltaTime, 0, 0);



    }
}
