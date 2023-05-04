using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFood : MonoBehaviour
{
    public GameObject tray;
    public GameObject player;
    public Vector3 headOffset;
  
    Rigidbody rb;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tray = gameObject;
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
            Debug.Log(player);
            PlayerMovement pm = player.GetComponent<PlayerMovement>();
            if ( pm!= null)
            {
                pm.tray = tray;
            }
            tray.transform.parent = (obj.gameObject.transform);
            tray.transform.position = player.transform.position + headOffset;
            rb.isKinematic = true;
            Debug.Log("Food caught");
        }
    }

}
