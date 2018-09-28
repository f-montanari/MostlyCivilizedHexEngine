using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMoveButton : MonoBehaviour
{
    public void SetMoveState()
    {
        // Play UI Sounds?
        MouseController.instance.SetMoveUpdate();
    }
}
