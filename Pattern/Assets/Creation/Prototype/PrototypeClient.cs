using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrototypeClient : MonoBehaviour
{
    public GameObject otherObj;

    void Clone() {
        Prototype pro = GetComponent<Prototype>();
        pro.Clone(otherObj);
    }

}
