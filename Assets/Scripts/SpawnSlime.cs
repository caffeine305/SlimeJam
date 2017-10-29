using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSlime : MonoBehaviour {

    public GameObject badSlime;
    public GameObject berrySlime;
    public GameObject blueSlime;
    public GameObject evilSlime;
    public GameObject goldenSlime;
    public GameObject greenSlime;
    public GameObject slimeMurasaki;
    public GameObject orangeSlime;
    public GameObject yellowSlime;

    GameObject chosenSlime;

    void Start () {
        StartCoroutine(RePositionWithDelay());
    }


    IEnumerator RePositionWithDelay() {

        //No se puede afectar directamente la rotación de un objeto en Unity
        //sus componentes son un cuaternio  

        Vector3 lookPos = new Vector3(0,0,0) ;
        var orientacion = Quaternion.LookRotation(lookPos);
        orientacion *= Quaternion.Euler(0, -90, 0); 
        transform.rotation = orientacion;

        while (true)
        {
            //Elegir posición aleatoria
            //SetRandomPosition();
            
            //Elegir color aleatorio
            SetRamdomColor();

            //Poner Slimes
            transform.position = new Vector3(-8f, -0.3f, -4.5f); 
            Instantiate(chosenSlime, transform.position, transform.rotation);

            yield return new WaitForSeconds(0.3f);
        }
    }

    void SetRandomPosition()
    {
        float x = Random.Range(-5.0f, 5.0f);
        float y = Random.Range(-5.0f, 5.0f);
        Debug.Log("X,Z:" + x.ToString("F2") + " , " + y.ToString("F2"));
        transform.position = new Vector3(x, y, 0.0f);
    }

    void SetRamdomColor()
    {
        int slimeColor;
        slimeColor = Random.Range(1,9);

        switch(slimeColor)
        {
            case 1:
                chosenSlime = badSlime;
                break;

            case 2:
                chosenSlime = berrySlime;
                break;

            case 3:
                chosenSlime = blueSlime;
                break;

            case 4:
                chosenSlime = evilSlime;
                break;

            case 5:
                chosenSlime = goldenSlime;
                break;

            case 6:
                chosenSlime = greenSlime;
                break;

            case 7:
                chosenSlime = slimeMurasaki;
                break;

            case 8:
                chosenSlime = orangeSlime;
                break;

            case 9:
                chosenSlime = yellowSlime;
                break;

            default:
                chosenSlime = greenSlime;
                break;
        }
    }


    
}
