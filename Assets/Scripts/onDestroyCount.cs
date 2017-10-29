using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onDestroyCount : MonoBehaviour {

    private ScoreMan scoreMan;

    public int valorScore;
    int eliminado;

    void Start()
    {
        GameObject LoadObject = GameObject.FindWithTag("GameController");
        if (LoadObject != null)
            scoreMan = LoadObject.GetComponent<ScoreMan>();

        if (LoadObject == null)
            Debug.Log("No se puede encontrar el Script 'scoreMan' ");

        eliminado = 0;
    }


    void OnMouseDown()
    {
        eliminado = 1;
        this.gameObject.SetActive(false);

        scoreMan.SumarScore(valorScore);
        scoreMan.UpdateEliminados(eliminado);

        Destroy(this.transform.root.gameObject, 2.0f);
    }
}
    

