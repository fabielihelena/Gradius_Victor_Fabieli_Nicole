using UnityEngine;
using System.Collections;

public class ShootBehaviour : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Finish")
        Destroy(gameObject);
        if (col.gameObject.tag == "Enemy")
            Destroy(col.gameObject);
    }

	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
	}
}
