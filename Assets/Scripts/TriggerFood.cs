using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFood : MonoBehaviour
{
    public GameObject tray;
    public float delay = 3;
    float timer; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider obj){
        if(obj.gameObject.tag == ("Player")){
        timer -= Time.deltaTime;
        if (timer<= 0)
        {
            var positionTrays = new Vector3(Random.Range(0f, 2.5f),5,0);
            Instantiate(tray, positionTrays, Quaternion.identity);
            timer = delay;
        }
        
        }
    }
}
