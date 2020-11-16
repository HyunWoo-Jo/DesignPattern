using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextStrategy : MonoBehaviour
{
    Strategy strategy;
    private void Awake() {
        strategy = GetComponent<ConcreteStrategyA>();
        strategy = GetComponent<ConcreteStrategyB>();
    }
}
