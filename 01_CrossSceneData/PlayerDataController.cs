using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDataController : MonoBehaviour {

    //死亡計數器
    public soDeadCounter DeadCounter = null;

    //單例
    public static PlayerDataController Instance = null;
    private void Awake() {
        if (PlayerDataController.Instance == null) {
            PlayerDataController.Instance = this;
            DontDestroyOnLoad(this);
            DeadCounter.f_Reset();
        }
        else {
            Destroy(this.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.A)) {
            SceneManager.LoadScene("TestScene1");
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            SceneManager.LoadScene("TestScene2");
        }
        if (Input.GetKeyDown(KeyCode.B)) {
            DeadCounter.DeadCount++;
        }
    }
}
