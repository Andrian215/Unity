using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Key key; // Посилання на скрипт ключа

    private void OnTriggerEnter(Collider other)
    {
        // Перевірка, чи гравець зіштовхнувся з дверима
        if (other.CompareTag("MainCamera"))
        {
            // Перевірка, чи гравець має ключ
            if (key.hasKey)
            {
                // Якщо ключ є, то знищуємо двері
                Destroy(gameObject);
                Debug.Log("Labyrinth completed, Congrats!");
            }
        }
    }
}
