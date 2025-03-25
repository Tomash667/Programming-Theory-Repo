using TMPro;
using UnityEngine;

public class ToasterManager : MonoBehaviour
{
    // ENCAPSULATION
    public static ToasterManager Instance { get; private set; }

    public GameObject selection;
    public TMP_Text text;

    private Toaster activeToaster;

    private void Awake()
    {
        Instance = this;
    }

    // ABSTRACTION
    public void SetActiveToaster(Toaster toaster)
    {
        activeToaster = toaster;
        selection.SetActive(true);
        selection.transform.position = toaster.gameObject.transform.position + Vector3.forward;
        text.text = $"Selected: {toaster.GetName()}";
    }
}
