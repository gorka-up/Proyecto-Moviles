using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GestorMenu : MonoBehaviour
{
    public GameObject texto;

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


    // Método para activar el texto y cuando le vuelvas a dar se desactiva


    public void ActivarTexto()
    {
        texto.SetActive(!texto.activeSelf);

    }



}