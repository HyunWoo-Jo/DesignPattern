using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteAdapter : MonoBehaviour, Adapter {
    Adaptee adaptee;
    private void Awake() {
        adaptee = GetComponent<Adaptee>();
    }
    public void Operation() {
        adaptee.OutText(); // Client가 사용할 수 있게 변환
    }
}
