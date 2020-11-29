using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Component;

public class Composite : MonoBehaviour, ComponentComputer {

    List<ComponentComputer> component_List = new List<ComponentComputer>();

    public int GetPower() {
        int result = 0;
        foreach(var item in component_List) {
            result += GetPower();
        }
        return result;

    }
    public int GetPrice() {
        int result = 0;
        foreach (var item in component_List) {
            result += GetPrice();
        }
        return result;
    }
}
