using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    private int randomBlue;

    // Start is called before the first frame update
    void Start()
    {
        i += 1;
        if (gameObject.tag == "Blue")
        { 
            randomBlue = Random.Range(150,251);
        
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log($"{gameObject.name}:{i}");
        i += 1;

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        
        }

        if (gameObject.tag == "Blue" && i == randomBlue)
        {
            rend.enabled = false;
        }
        
        
        
        
    }
}
