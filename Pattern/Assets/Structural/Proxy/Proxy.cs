using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proxy : MonoBehaviour, ProxySubject
{
    RealSubject real;
    private void Awake() {
        real = GetComponent<RealSubject>();
    }
    public void Action() {
        real.Action();
    }
}
