using UnityEngine;
using UnityEngine.InputSystem;

public class EnableKey : MonoBehaviour
{
    public GameObject objectToEnable;

    void Update()
    {
        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            objectToEnable.SetActive(true);
        }
    }
}
