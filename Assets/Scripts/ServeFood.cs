using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServeFood : MonoBehaviour
{
    public GameObject tableTop;
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
            
            // Attach the tray instance to the table top
            trayInstance.transform.SetParent(tableTop.transform,true);
            trayInstance.transform.position = tableTop.transform.position;
            

            Debug.Log("Food served");
        }
    }

}
