using UnityEngine;
using System.Collections;

public class ChangerScene : MonoBehaviour {
    public int levelIndex;
    public GameObject rocha;
    int timer;
    public int limit;
	// Use this for initialization
	void Start () {
        Screen.SetResolution(25, 10, false);
	}

	// Update is called once per frame
	void Update () {
	if(name.Equals("nextFase"))
    {
        Application.LoadLevel(levelIndex);
    }
    timer++;
    if (timer > limit)
    {
        Instantiate(rocha, new Vector3(transform.position.x, Random.Range(-3, 4), transform.position.z), Quaternion.identity);


        timer = 0;
    }


	}
}
