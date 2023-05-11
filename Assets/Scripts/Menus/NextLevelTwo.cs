using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevelTwo : MonoBehaviour
{
    public Button button;
    public Text trayScore;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        trayScore.text = "Food Trays Served: " + GameManager.Instance.foodServed.ToString();
    }

    void TaskOnClick(){
        SceneManager.LoadScene("MainLevelThree");
    }
}