using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public int order1;
    public int order2;
    public int order3;
    private int random1;
    private int random2;
    private int random3;
    int cubenumber1;
    [SerializeField] private GameObject cube1;
    [SerializeField] private GameObject cube2;
    [SerializeField] private GameObject cube3;
    Object_Interaction Cubenumber;


    // Start is called before the first frame update
    void Start()
    {
        Cubenumber = cube1.GetComponent<Object_Interaction>();
        cubenumber1 = Cubenumber.cubenumber;

        random1 = Random.Range(1, 3);
        random2 = Random.Range(1, 3);
        random3 = Random.Range(1, 3);
        randomize();
       

    }

    // Update is called once per frame
    void Update()
    {

        
        AskingOrder();
    }
    public void randomize()
    {
        order1 = random1;
        order2 = random2;
        order3 = random3;
    }

    private void AskingOrder() {

        if (order1 == 1)
        {
            Debug.Log("I want Blue");
        }
        if (order1 == 2) {
            Debug.Log("I want purple");
        }
        if (order1 == 3)
        {
            Debug.Log("I want yellow");

        }

    
    }
    }


