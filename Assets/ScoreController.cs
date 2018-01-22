using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
    private GameObject scoreText;
    private int score = 0;
    private int smallstarscore = 5;
    private int largestarscore = 10;
    private int cloudscore = 15;
	// Use this for initialization
	void Start () {
        this.scoreText = GameObject.Find("Score");
	}
	
	// Update is called once per frame
	void Update () {

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag== "SmallStarsTag")
        {
            this.score += smallstarscore;

        }
        else if (collision.gameObject.tag == "largeStarTag")
        {
            this.score += largestarscore;
        }
        else if (collision.gameObject.tag == "SmallCloudTag" || collision.gameObject.tag == "LargeCloudTag")
        {
            this.score += cloudscore;
        }
        scoreText.GetComponent<Text>().text = score.ToString();
    }
}
