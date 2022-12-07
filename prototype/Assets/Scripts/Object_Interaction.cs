using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Interaction : MonoBehaviour
{
    private Transform PickUpPoint;
    private Transform player;

    public float PickUpDistance;
    public float ForceMulti;
    public int cubenumber;

    public bool ReadyToThrow;
    public bool ItemisPicked;
    private Rigidbody rb;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        player = GameObject.Find("Player").transform;
        PickUpPoint = GameObject.Find("Interact").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E)&& ItemisPicked==true && ReadyToThrow)
        {
            ForceMulti += 300 * Time.deltaTime;
                
        }

        PickUpDistance = Vector3.Distance(player.position, transform.position);

        if (PickUpDistance <= 10)
        {
            if(Input.GetKeyDown(KeyCode.R)  && ItemisPicked==false && PickUpPoint.childCount < 1)
            {

                GetComponent<Rigidbody>().useGravity = false;
                GetComponent<BoxCollider>().enabled = false;
                this.transform.position = PickUpPoint.position;
                this.transform.parent = GameObject.Find("Interact").transform; 

                ItemisPicked = true;
                ForceMulti = 0;

            }
        
        
        }
        if (Input.GetKeyUp(KeyCode.E) && ItemisPicked == true)
        {

            ReadyToThrow = true;
            if (ForceMulti > 10)
            {
                rb.AddForce(player.transform.forward * ForceMulti);
                this.transform.parent = null;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<BoxCollider>().enabled = true;
                ItemisPicked = false;   

                ForceMulti = 0;
                ReadyToThrow = false;
            }
            ForceMulti = 0;
        }
    }

}
