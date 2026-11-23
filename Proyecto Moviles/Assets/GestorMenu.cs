using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorMenu : MonoBehaviour
{
    public void IrAEscenaAR()
    {
        SceneManager.LoadScene("Minijuego_AR");
    }

    public void IrAEscenaGPS()
    {
        SceneManager.LoadScene("Minijuego_GPS");
    }

    public void IrAEscenaNormal()
    {
        SceneManager.LoadScene("Minijuego_Normal");
    }
}