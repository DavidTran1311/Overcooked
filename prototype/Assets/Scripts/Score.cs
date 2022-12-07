using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
   
    [SerializeField] GameObject blue;
    [SerializeField] GameObject Purple;
    [SerializeField] GameObject Yellow;
   
    Object_Interaction cube1;
    int cubenumber1;


    [SerializeField] GameObject GameManager;
    Randomizer order;
    int ordernumber;
    
    
    int point=0;
    // Start is called before the first frame update
    void Start()
    {
      cube1 = blue.GetComponent<Object_Interaction>();
      cubenumber1 = cube1.cubenumber;

        order = GameManager.GetComponent<Randomizer>();
        ordernumber = order.order1;
     
    }

    // Update is called once per frame
    void Update()
    {
        ordernumber = order.order1;
        Debug.Log("your ordernumber is:"+ordernumber);
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interactable" && ordernumber==cubenumber1 )
        {
           point++;
            Debug.Log("you have"+ point);
            Destroy(other.gameObject);
            

        }
    }
 

}
