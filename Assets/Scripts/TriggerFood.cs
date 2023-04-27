// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class TriggerFood : MonoBehaviour
// {
//     public GameObject tray;
//     public float delay = 3;
//     float timer; 
//     bool hitTrigger;
//     // Start is called before the first frame update
//     void Start()
//     {

//     }

//     void Update()
//     {
//         timer -= Time.deltaTime;
//         if (timer<= 0 && hitTrigger)
//         {
//             for (int i=0; i<3; i++){
//                 var positionTrays = new Vector3(Random.Range(-3f, 0f),2.631f,19.48f);
//                 Instantiate(tray, positionTrays, Quaternion.identity);
//                 timer = delay;
//             }
//         }
//     }

//     void OnTriggerEnter(Collider obj){
//         if(obj.gameObject.tag == ("Player")){
//             hitTrigger = true;
//             Debug.Log(hitTrigger);
//         }
//     }
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFood : MonoBehaviour
{
    public GameObject tray;
    public float delay = 3;
    private int maxTrays = 10;
    float timer; 
    bool hitTrigger;

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
                    var positionTrays = new Vector3(Random.Range(-3f, 0f), 2.831f, 19.48f);
                    Instantiate(tray, positionTrays, Quaternion.identity);
                }
                timer = delay;
            }
        }
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

