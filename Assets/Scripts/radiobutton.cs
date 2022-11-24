using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class radiobutton : MonoBehaviour
{
    ToggleGroup toggleGroup;
    void Start()
    {
    toggleGroup = GetComponent<ToggleGroup>();
    }

    public void Submit()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
    }
}
