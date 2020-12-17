using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Data", menuName = "ScriptableObject/Create 死亡計數器", order = 1)]
/// <summary> 死亡計數器 </summary>
public class soDeadCounter : ScriptableObject {

    /// <summary> 死亡次數 </summary>
    public int DeadCount = 0;

    /// <summary> 重置 </summary>
    public void f_Reset() {
        DeadCount = 0;
    }
}
