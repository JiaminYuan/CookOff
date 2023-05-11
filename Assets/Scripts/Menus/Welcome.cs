using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){
        // reset score here
        SceneManager.LoadScene("Welcome");
    }

    // Update is called once per frame
    void Update()
    {

    }
}