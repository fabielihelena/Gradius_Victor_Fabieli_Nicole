using UnityEngine;
using System.Collections;

public class BossMove : MonoBehaviour {
    public float speedz;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.z > 60)
        {
            speedz *= -1;
        }
        else if(transform.position.z < 52)
        {
            speedz *= -1;
        }
        transform.position += new Vector3(0, 0, speedz * Time.deltaTime);
	}
}
