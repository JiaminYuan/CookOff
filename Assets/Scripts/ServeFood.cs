using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServeFood : MonoBehaviour
{

    public GameObject table;
    public GameObject tray;
    private float headOffset = 1f;
  //  Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == ("Player"))
        {
            tray.transform.parent = (table.gameObject.transform);
            tray.transform.localPosition = table.transform.position + Vector3.up * headOffset;
           // rb.isKinematic = true;
            Debug.Log("Food served");
        }
    }
}
