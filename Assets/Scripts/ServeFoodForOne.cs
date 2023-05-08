using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServeFoodForOne : MonoBehaviour
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

            if(tableTop.transform.childCount == 0){
                // Attach the tray instance to the first tray position
                trayInstance.transform.SetParent(tableTop.transform,true);
                trayInstance.transform.position = tableTop.transform.position;
                trayInstance.transform.localScale = new Vector3(2, 1, 1);
                trayInstance.transform.localRotation = Quaternion.identity;
                Debug.Log("Food served to the client");
            }else{
                Debug.Log("Serve to the next table!");
            }

        }
    }
}

