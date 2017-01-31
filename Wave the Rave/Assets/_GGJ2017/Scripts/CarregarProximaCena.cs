using UnityEngine;

public class CarregarProximaCena : MonoBehaviour 
{
    void Start()
    {
        Invoke("CPCena", 2f);
    }

    void CPCena()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
