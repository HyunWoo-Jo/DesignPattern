using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteAggregate : MonoBehaviour, Aggregate
{
    public void CreateIterator() {
        Iterator iterator = GetComponent<Iterator>(); ;
        iterator.Next();
    }

  
}
