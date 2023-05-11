using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // public GameObject position1;
    // public GameObject position2;
    // public GameObject position3;
    // public GameObject position4;
    // public GameObject position5;
    // public GameObject position6;
    public int foodServed;
    public Text scoreText;
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void CountFoodServed(){
        foodServed += 1;
        scoreText.text = "Served: " + foodServed.ToString();
    }


}