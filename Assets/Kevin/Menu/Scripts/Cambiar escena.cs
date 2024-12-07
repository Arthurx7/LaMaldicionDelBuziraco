using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiarescena : MonoBehaviour
{
    // Start is called before the first frame update
    public void CloseApplication()
    {
        // Verifica si estamos en el editor de Unity
#if UNITY_EDITOR
        // Si estamos en el editor, simplemente detenemos la simulación
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // Si estamos en una compilación, cerramos la aplicación
            Application.Quit();
#endif
    }

    public void CambiarEscena()
    {
        SceneManager.LoadScene(1);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    
}
