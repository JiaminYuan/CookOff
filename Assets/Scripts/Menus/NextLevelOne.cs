using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevelOne : MonoBehaviour
{
    public Button button;
    public Text trayScore;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        trayScore.text = gameManager.foodServed.ToString();
    }

    void TaskOnClick(){
        SceneManager.LoadScene("Main");
    }
}