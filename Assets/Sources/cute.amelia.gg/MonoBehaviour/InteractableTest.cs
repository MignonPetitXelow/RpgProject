using UnityEngine;
using UnityEngine.InputSystem;

public class InteractableTest : MonoBehaviour
{
    [SerializeField] private InputActionReference use;
    [SerializeField] private GameObject prefab;
    [SerializeField] private bool isTrigger = false;

    void OnTriggerEnter(Collider other)
    {
        isTrigger = true;
    }
    void OnTriggerExit(Collider other)
    {
        isTrigger = false;
    }

    void OnEnable()
    {
        use.action.performed += PerformUse;
    }

    void OnDisable()
    {
        use.action.performed -= PerformUse;
    }

    private void PerformUse(InputAction.CallbackContext context)
    {
        if(isTrigger)
        {
            GameObject.Instantiate(prefab).transform.SetParent(GameObject.FindGameObjectsWithTag("CANVAS")[0].GetComponent<Canvas>().transform, false);
        }
    }
}