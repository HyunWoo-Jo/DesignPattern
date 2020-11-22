using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AConcreteCommand : MonoBehaviour, Command {
    private void Left() {
        Debug.Log("Left");
    }
    public void Execute() {
        this.Left();
    }
}
