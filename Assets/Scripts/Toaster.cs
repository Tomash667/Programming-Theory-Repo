using UnityEngine;

// INHERITANCE
public abstract class Toaster : MonoBehaviour
{
    // POLYMORPHISM
    public abstract string GetName();

    private void OnMouseDown()
    {
        ToasterManager.Instance.SetActiveToaster(this);
    }
}
