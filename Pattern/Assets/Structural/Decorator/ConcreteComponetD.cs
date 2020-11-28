using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteComponetD : MonoBehaviour, ComponentD
{
    Decorator decorator;
    private void Awake() {
        decorator = GetComponent<Decorator>();
    }
    public void Operation() {
        decorator.Operation();
    }

}
