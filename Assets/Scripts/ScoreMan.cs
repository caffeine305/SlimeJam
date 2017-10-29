using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMan : MonoBehaviour {

    public int score;
    public int eliminated;
    public GameObject scoreText;

	void Start () {
        score = 0;

        transform.position = new Vector3(-35.5f, 13.0f, 10f);
        Instantiate(scoreText, transform.position, transform.rotation);
    }


    public void SumarScore(int sumarValorScore)
    {
            score += sumarValorScore;
            UpdateScore();       
    }

    void UpdateScore()
    {
            scoreText.GetComponent<TextMesh>().text = "Score:" + score;
            Debug.Log(score);
    }

    public void UpdateEliminados(int sumarNumEliminados)
    {
        eliminated += sumarNumEliminados;
    }

    void Update () {
		
	}
}
