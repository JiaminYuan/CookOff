using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServeFood : MonoBehaviour
{
    public GameObject tableTop;
    public GameObject tableTop2;

    public GameObject trayInstance;
    
    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            PlayerMovement pm = obj.gameObject.GetComponent<PlayerMovement>();
            if ( pm!= null)
            {
                trayInstance = pm.tray;
            }

            if(tableTop.transform.childCount == 0){
                // Attach the tray instance to the first tray position
                trayInstance.transform.SetParent(tableTop.transform,true);
                trayInstance.transform.position = tableTop.transform.position;
                Debug.Log("Food served to first client");  
            }else{
                // Attach the tray instance to the second tray position
                trayInstance.transform.SetParent(tableTop2.transform,true);
                trayInstance.transform.position = tableTop2.transform.position;
                Debug.Log("Food served to second client");
            }
            
        }
    }

}
