using UnityEngine;using System.Collections;
using UnityEngine.UI;
using System.IO;
public class Respawn : MonoBehaviour {


    public GameObject[] spawnObject;
    public GameObject boss;
    private int timer = 0;
    public int limit;
    public int score;
    public bool bossIsDead = true;
    int scoreLimit = 20;
    public bool hasBoss = false;
    public int highScore;
    Text pontos;
    Text vida;
    Text HS;
    public GameObject jogador;
    string[] savedData;
	// Use this for initialization
	void Start () {
        vida = GameObject.FindGameObjectWithTag("Life").GetComponent<Text>();
        pontos = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        HS = GameObject.FindGameObjectWithTag("HS").GetComponent<Text>();
        savedData = File.ReadAllLines("save.txt");
        highScore = int.Parse(savedData[0]);
        //jogador = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
       vida.text = "Vida: " + GameObject.FindGameObjectWithTag("Player").GetComponent<GradiusBehaviour>().hp.ToString();
        pontos.text = "Pontos: " + score.ToString();
        HS.text = "Melhor Pontuacao :" + highScore;
        timer++;

        if(score == scoreLimit && hasBoss)
        {
            hasBoss = false;
        }

        if(timer > limit && score < scoreLimit && bossIsDead)
        {
            int a = Random.Range(0, spawnObject.Length);
            switch (a)
            {
                case 0:
                    Instantiate(spawnObject[0], new Vector3(69f, -1.67f, Random.Range(52, 56)),spawnObject[0].transform.rotation );
                    break;

                case 1:
                    Instantiate(spawnObject[1], new Vector3(70f, -1.67f, Random.Range(52, 56)), Quaternion.identity);
                    break;

                case 2:
                    Instantiate(spawnObject[2], new Vector3(70f, -1.67f, 53f), Quaternion.identity);
                    break;

                case 3:
                    Instantiate(spawnObject[3], new Vector3(70f, -1.67f, 52.5f), Quaternion.identity);
                    break;
            }

            timer = 0;
        }
        
         if(!hasBoss && score.Equals(scoreLimit))
        {
            Instantiate(boss);
            scoreLimit += 20;
            bossIsDead = false;
            GameObject[] o = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < o.Length; i++)
                Destroy(o[i]);

                hasBoss = true;
        }

	}
}
