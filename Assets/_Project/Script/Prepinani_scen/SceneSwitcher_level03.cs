using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher_level03 : MonoBehaviour
{
    // N�zev c�lov� sc�ny, na kterou chceme p�epnout
    public string targetScene;

    // Metoda, kter� se zavol�, kdy� hr�� interaguje s objektem



    /*private void OnTriggerEnter(Collider other)
    {
        // Pokud hr�� interaguje s hr��ov�m gameobjectem
        if (other.gameObject.CompareTag("Player"))
        {
            // P�epneme na c�lovou sc�nu
            SceneManager.LoadScene(3);
        }
    
    }
    */
    private void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Player") {
            SceneManager.LoadScene(4);
        }
    }

}






