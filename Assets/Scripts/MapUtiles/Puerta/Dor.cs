using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dor : MonoBehaviour
{
    private bool llabe;

    private void Start()
    {
        llabe = false;
    }

    private void Update()
    {
        if (llabe){ 
            Destroy(this.gameObject, 3);
        }

    }

    public void llaveConseguida()
    {
        llabe = true;
    }
}
