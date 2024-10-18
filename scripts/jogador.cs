using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("Começou");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up")){
            this.transform.position += new Vector3(0, 0.01f);

        }else if (Input.GetKey("down")){
            this.transform.position += new Vector3(0, -0.01f);

        }
    }
}
