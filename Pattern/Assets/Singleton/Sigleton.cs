using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sigleton<T> : MonoBehaviour where T : Sigleton<T>
{
    static T Instance;
    private void Awake() {
        if (Instance != null) {
            Destroy(this.gameObject);
        } else {
            Instance = this.GetComponent<T>();
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
