using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i += 1;
        //Debug.Log($"{gameObject.name}:{i} (from start)");
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameObject != null)
        
            Debug.Log($"{gameObject.name}:{i}");
            i += 1;
        
        //else 
           // Debug.LogError("gameObject is null");
        
        
    }
}
