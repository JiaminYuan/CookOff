using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServeFoodForTwo : MonoBehaviour
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

            if(tableTop.transform.childCount == 0 && tableTop2.transform.childCount == 0){
                // Attach the tray instance to the first tray position
                trayInstance.transform.SetParent(tableTop.transform,true);
                trayInstance.transform.position = tableTop.transform.position;
                trayInstance.transform.localScale = new Vector3(2, 1, 1);
                trayInstance.transform.localRotation = Quaternion.identity;
                Debug.Log("Food served to first client");
            }else if(tableTop.transform.childCount == 1 && tableTop2.transform.childCount == 0){
                // Attach the tray instance to the second tray position
                trayInstance.transform.SetParent(tableTop2.transform,true);
                trayInstance.transform.position = tableTop2.transform.position;
                trayInstance.transform.localScale = new Vector3(2, 1, 1);
                trayInstance.transform.localRotation = Quaternion.identity;
                Debug.Log("Food served to second client");
            }else{
                Debug.Log("Serve to the next table!");
            }

        }
    }

}