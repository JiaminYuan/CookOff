using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject position1;
    public GameObject position2;
    public GameObject position3;
    public GameObject position4;
    public GameObject position5;
    public GameObject position6;
    public int foodServed;
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CountFoodServed();
    }

    public void CountFoodServed(){
        int trayCount = 0;

        trayCount += position1.transform.childCount;
        trayCount += position2.transform.childCount;
        trayCount += position3.transform.childCount;
        trayCount += position4.transform.childCount;
        trayCount += position5.transform.childCount;
        trayCount += position6.transform.childCount;

        foodServed += trayCount;
        scoreText.text = "Served: " + foodServed.ToString();
    }

}