using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteDecorator : MonoBehaviour, ComponentD {
    private int addedState;

    public void Operation() {
        AddedBehavior();
    }
    public void AddedBehavior() {

    }
}
