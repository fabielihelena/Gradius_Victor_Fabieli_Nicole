using UnityEngine;
using System.Collections;

public class BossBehaviour : Default {

    public float speedz;
    public int life = 20;

	// Use this for initialization
	void Start () {

	}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Colidiu: " + col.gameObject.name);
        if (col.gameObject.tag == "Bullet")
        {
            Debug.Log("LOL");
            life--;
            Destroy(col.gameObject);
        }
    }
   
	// Update is called once per frame
	void Update () {
        if (life <= 0)
        {
            Debug.Log(life);
            Destroy(transform.parent.gameObject);
            Destroy(gameObject);
        }
	}
}
