using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//bridge
public class ControllObject : MonoBehaviour, BridgeImpl
{
    public GameObject targetObject;

    public void Close() {
        targetObject.SetActive(false);
    }

    public void Open() {
        targetObject.SetActive(true);
    }
}
