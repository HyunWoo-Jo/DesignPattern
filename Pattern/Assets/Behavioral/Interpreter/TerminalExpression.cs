using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalExpression : MonoBehaviour, AbstractExpression
{
    string data;
    public TerminalExpression(string data) {
        this.data = data;
    }
    public void Interpret(string con) {
        Debug.Log("TerminalExpression:" + con);
    }
}
