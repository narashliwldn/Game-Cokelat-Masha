using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript Instance;
    public int score = 0;
    public int health = 3;
    public Text scoreText, healthText;
    public GameObject panelGameObject;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(health < 1){
            panelGameObject.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Candy"){
            score+=1;
            scoreText.text = "Score: " + score;
        }
        if(other.gameObject.tag == "Obstacle"){
            health-=1;
            healthText.text = "Health: " + health;
        }
    }

    public void Restart(){
        SceneManager.LoadScene("SampleScene");
    }
}
