using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    private BridgeImpl impl;
    public void Open() {
        impl.Open();
    }
    public void Close() {
        impl.Close();
    }
    private void Awake() {
        impl = GetComponent<BridgeImpl>();
    }
}
