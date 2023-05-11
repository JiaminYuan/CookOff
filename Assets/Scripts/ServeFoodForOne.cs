using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ServeFoodForOne : MonoBehaviour
{
    public GameObject tableTop;

    public GameObject trayInstance;

    public Text statusText;

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
                if (pm.transform.Find("Tray_01_Setup_01(Clone)") != null)
                {
                    // Attach the tray instance to the first tray position
                    trayInstance.transform.SetParent(tableTop.transform,true);
                    trayInstance.transform.position = tableTop.transform.position;
                    trayInstance.transform.localScale = new Vector3(2, 1, 1);
                    trayInstance.transform.localRotation = Quaternion.identity;
                   // Debug.Log("Food served to the client");
                    statusText.text = "Food served to the client";
                    GameManager.Instance.CountFoodServed();
                }else{
                    //Debug.Log("Go get the food!");
                    statusText.text = "Go get the food!";
                }
            }else{
                //Debug.Log("Serve to the next table!");
                statusText.text = "Serve to the next table!";
            }

        }
    }
}