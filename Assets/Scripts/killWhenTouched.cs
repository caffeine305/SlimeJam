using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killWhenTouched : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Slime")
        {
            Destroy(other.transform.root.gameObject);
        }

    }
}
