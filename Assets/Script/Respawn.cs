using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {


    public GameObject spawnObject;
    private int timer = 0;
    public int limit;
    public int score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        timer++;

        if(timer > limit)
        {
            Instantiate(spawnObject, new Vector3(transform.position.x,transform.position.y,Random.Range(52,60)), Quaternion.identity);
            timer = 0;
        }
	}
}
