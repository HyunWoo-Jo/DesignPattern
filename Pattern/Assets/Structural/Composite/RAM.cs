using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Component {
    public class RAM : MonoBehaviour, ComponentComputer {
        public int power, price;

        public int GetPower() {
            return power;
        }

        public int GetPrice() {
            return price;
        }
    }
}