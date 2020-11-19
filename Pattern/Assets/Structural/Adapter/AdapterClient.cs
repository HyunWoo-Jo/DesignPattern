using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdapterClient : MonoBehaviour
{
    Adapter adapter;
    private void Awake() {
        adapter = GetComponent<Adapter>();
        adapter.Operation();
    }
}
