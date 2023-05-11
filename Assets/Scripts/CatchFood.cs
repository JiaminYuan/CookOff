using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CatchFood : MonoBehaviour
{
    public GameObject tray;
    public GameObject player;
    public Vector3 headOffset;

    private Text statusText;
  
    Rigidbody rb;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tray = gameObject;
        statusText =  GameObject.FindGameObjectWithTag("Status").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == ("Player"))
        {
            player = obj.gameObject;
            PlayerMovement pm = player.GetComponent<PlayerMovement>();
            if ( pm!= null)
            {
                pm.tray = tray;
            }
            tray.transform.parent = (obj.gameObject.transform);
            tray.transform.position = player.transform.position + headOffset;
            rb.isKinematic = true;
            statusText.text = "Food caught";
        }
    }

}
