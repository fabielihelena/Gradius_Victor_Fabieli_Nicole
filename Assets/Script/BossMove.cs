using UnityEngine; 
using System.Collections;

public class BossMove : MonoBehaviour {
    public float speedz;
    public float speedZ;
    public string move;
	// Use this for initialization
	void Start () {
        speedZ = speedz;    
	}
	// Update is called once per frame
	void Update () {
        if(transform.position.z > 56.5)
        {
            move = "desce";
        }
        else if(transform.position.z < 52)
        {
            move = "sobe";
        }

        if (move.Equals("sobe"))
        {
            speedZ = speedz;
        }
        if (move.Equals("desce"))
        {
            speedZ = -speedz;
        }

        transform.position += new Vector3(0, 0, speedZ * Time.deltaTime);
	}
}
