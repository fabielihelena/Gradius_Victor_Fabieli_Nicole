using UnityEngine;
using System.Collections;

public class GradiusBehaviour : Default {
    public float speed;
    public float hp;
    public string stats;
    public float horizontal;
    public float vertical;
	// Use this for initialization
	void Awake () {
        
	}
	
	// Update is called once per frame
	void Update () {
        horizontal = Input.GetAxisRaw("Horizontal") ;
        vertical = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(speed * horizontal * Time.deltaTime, 0, vertical * speed * Time.deltaTime);
	}
}
