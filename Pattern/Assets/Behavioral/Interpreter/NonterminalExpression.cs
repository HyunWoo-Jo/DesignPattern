using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonterminalExpression : MonoBehaviour, AbstractExpression
{
    public void Interpret(string con) {
        Debug.Log("NontminalExpression:" + con);
    }

}
