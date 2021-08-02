using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour {

    [SerializeField] GameObject room;
    private GameObject spawn;
    private int exitCount;

    void Start() {
        exitCount = GameObject.FindGameObjectsWithTag("Exit").Length;
    }

    // Update is called once per frame
    void Update() {

    }

    private void Load() {
        spawn = GameObject.FindGameObjectWithTag("Spawn");
    }
}
