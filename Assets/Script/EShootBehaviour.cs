using UnityEngine;
using System.Collections;

public class EShootBehaviour : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<GradiusBehaviour>().hp -= 1;
            Destroy(gameObject);
        }
        if(col.gameObject.tag=="Finish")
        {
            Destroy(gameObject);
        }
    }

	// Update is called once per frame
	void Update () {
        rigidbody.velocity = Vector3.zero;
        rigidbody.AddForce(-speed, 0, 0, ForceMode.Impulse);
	}
}
