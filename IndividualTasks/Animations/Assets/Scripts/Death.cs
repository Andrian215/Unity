using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject knight;

    void OnTriggerEnter(Collider coll)
    {
        coll.GetComponent<Animation>().Death();
        knight.GetComponent<Player>().enabled = false;
        knight.GetComponent<Animation>().enabled = false;
        Invoke("ReloadScene", 3f);
    }

    private void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
