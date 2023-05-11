using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerFood : MonoBehaviour
{
    public GameObject tray;
    public GameObject[] pipes;
    public float delay = 3;
    private int maxTrays = 10;
    float timer; 
    bool hitTrigger;

    public Text statusText;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        if (hitTrigger)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                if (GameObject.FindGameObjectsWithTag("Tray1").Length <= maxTrays)
                {
                    GameObject player = GameObject.FindWithTag("Player");

                    bool hasChildTray = false;
                    foreach (Transform child in player.transform) {
                        if (child.name == "Tray_01_Setup_01(Clone)") {
                            hasChildTray = true;
                            break;
                        }
                    }

                    if (hasChildTray) {
                        statusText.text = "Ready to serve";
                    } else {
                       var pipeNumber = Random.Range(1, 4);
                        if(pipeNumber ==1){
                            Invoke("SpawnFromThirdPipe", 2.0f);
                            statusText.text = "Food spawning on 3rd pipe";
                        }
                        if(pipeNumber ==2){
                            Invoke("SpawnFromSecondPipe", 2.0f);
                            statusText.text = "Food spawning on 2nd pipe";
                        }
                        if(pipeNumber ==3){
                            Invoke("SpawnFromFirstPipe", 2.0f);
                            statusText.text = "Food spawning on 1st pipe";
                        } 
                    }

                    
                }
                timer = delay;
            }
        }
    }

    void SpawnFromThirdPipe(){
        var pipePosition1 =  new Vector3(0.0f, 2.631f, 20.00f);
        Instantiate(tray, pipePosition1, Quaternion.identity);
        pipes[0].GetComponent<Renderer>().material.color = Color.red;
        pipes[1].GetComponent<Renderer>().material.color = Color.red;
        pipes[2].GetComponent<Renderer>().material.color = Color.yellow;

    }

    void SpawnFromSecondPipe(){
        var pipePosition2 =  new Vector3(-2.55f, 2.631f, 20.00f);
        Instantiate(tray, pipePosition2, Quaternion.identity);
        pipes[0].GetComponent<Renderer>().material.color = Color.red;
        pipes[1].GetComponent<Renderer>().material.color = Color.yellow;
        pipes[2].GetComponent<Renderer>().material.color = Color.red;
    }

    void SpawnFromFirstPipe(){
        var pipePosition3 =  new Vector3(-4.92f, 2.631f, 20.00f);
        Instantiate(tray, pipePosition3, Quaternion.identity);
        pipes[0].GetComponent<Renderer>().material.color = Color.yellow;
        pipes[1].GetComponent<Renderer>().material.color = Color.red;
        pipes[2].GetComponent<Renderer>().material.color = Color.red;
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == ("Player"))
        {
            hitTrigger = true;
            Debug.Log(hitTrigger);
        }
    }

    void OnTriggerExit(Collider obj)
    {
        if (obj.gameObject.tag == ("Player"))
        {
            hitTrigger = false;
            Debug.Log(hitTrigger);
        }
    }
}