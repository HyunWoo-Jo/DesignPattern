using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandReceiver : MonoBehaviour
{
    private Command theACommand;
    private Command theBCommand;

    private void Awake() {
        theACommand = GetComponent<AConcreteCommand>();
        theBCommand = GetComponent<BConcreteCommand>();
    }
    public void Left() {
        theACommand.Execute();
    }
    public void Right() {
        theBCommand.Execute();
    }
}
