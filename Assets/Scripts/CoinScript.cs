using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    static int score = 0; // якщо змінна паблік, то її можна редагувати в юніті + якщо монеток декілька int має бути static + використовується int бо рахунок буде у цілих числах
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){ //Вказуємо що скрипт застосовується коли 2д колайдер взаємодіє з чимось іншим
        Debug.Log ("Triggered"); //виводимо лог
        Destroy (gameObject); // кажемо що об'єкут з яким взаємодіє наш об'єкт знищується
        score++;
        Debug.Log ("Score: " + score);
    }
}
