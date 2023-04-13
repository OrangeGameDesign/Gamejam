using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher_konec_hry : MonoBehaviour
{
    // Název cílové scény, na kterou chceme pøepnout
    public string targetScene;

    // Metoda, která se zavolá, když hráè interaguje s objektem



    /*private void OnTriggerEnter(Collider other)
    {
        // Pokud hráè interaguje s hráèovým gameobjectem
        if (other.gameObject.CompareTag("Player"))
        {
            // Pøepneme na cílovou scénu
            SceneManager.LoadScene(3);
        }
    
    }
    */
    private void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Player") {
            SceneManager.LoadScene(0);
        }
    }

}






