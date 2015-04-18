using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
public class GradiusBehaviour : Default {
    public float speed;
    public int hp;
    public string stats;
    public GameObject Bullet;
    public float subtractor = 1f ;
	// Use this for initialization
	void Awake () {
        
	}
	
	// Update is called once per frame
	void Update () {
        rigidbody.velocity = Vector4.zero;
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && transform.position.z < 58.5 ) 
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            if(transform.rotation.eulerAngles.z < 180) transform.Rotate(0, 0, 0.7f);
            subtractor = -1;
        }

        if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && transform.position.z > 52)
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
            if (transform.rotation.eulerAngles.z > 0) transform.Rotate(0, 0, -0.7f);
            subtractor = 1;
        }

        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && transform.position.x > 49)
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }

        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && transform.position.x < 72)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, transform.position + new Vector3(0.5f, 0, 0), Quaternion.identity);
        }

        if (!(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && !(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)))
        {
            float  rada = 360f - transform.rotation.eulerAngles.z;
            if (transform.rotation.eulerAngles.z > 95 )
            {
                transform.Rotate(0, 0, subtractor);
                
            }
            if (transform.rotation.eulerAngles.z < 89)
            {
                transform.Rotate(0, 0, subtractor);
            }
        }
        if(hp <= 0)
        {
            Destroy(gameObject);
            string[] s = new string[1];
            s[0] = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Respawn>().score.ToString();
            File.WriteAllLines("save.txt", s);
            Application.LoadLevel(0);
        }

	}
}
