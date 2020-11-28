using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcretePrototypeA : MonoBehaviour, Prototype
{
    public string objectName;
    public int hp;
    public int maxHp;


    public void Clone(GameObject obj) {
        var pro = obj.GetComponent<ConcretePrototypeA>();
        PropertyClon(pro);
    }
    private void PropertyClon(ConcretePrototypeA pro) {
        pro.objectName = this.objectName;
        pro.hp = this.hp;
        pro.maxHp = this.maxHp;
    }

}
