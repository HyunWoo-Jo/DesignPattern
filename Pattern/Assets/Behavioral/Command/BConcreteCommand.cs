using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BConcreteCommand : MonoBehaviour, Command
{
    private void Right() {
        Debug.Log("Right");
    }
    public void Execute() {
        this.Right();
    }
}
