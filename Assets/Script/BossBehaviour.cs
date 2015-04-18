using UnityEngine;
using System.Collections;

public class BossBehaviour : Default {

    public float speedz;
    public int life = 20;
    public GameObject bullet;
    int timer = 0;
    public int limit;
	// Use this for initialization
	void Start () {

	}
    
   
	// Update is called once per frame
	void Update () {
        if (life <= 0)
        {
            Debug.Log(life);
            Destroy(transform.parent.gameObject);
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Respawn").GetComponent<Respawn>().bossIsDead = true;
        }
        timer++;
        if(timer > limit)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            timer = 0;
        }
	}
}
