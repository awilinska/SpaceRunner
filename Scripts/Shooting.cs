using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform gun;
    public int bulletCount = 3;
    public Text bulletsDisplay;
    public GameObject shotSound;
    public GameObject emptySound;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            Shoot();
            bulletCount -= 1;
        }
        
        if (bulletCount >= 0) {
            bulletsDisplay.text = ("Bullets: " + bulletCount.ToString());
        }
        else {
            bulletsDisplay.text = ("Bullets: 0");
        }
        
    }

    void Shoot() {
        if (bulletCount <= 0) {
            Instantiate(emptySound, transform.position, Quaternion.identity);
            return;
        }

        Instantiate(shotSound, transform.position, Quaternion.identity);
        GameObject si = Instantiate(bullet, gun);
        si.transform.parent = null;
    }
}
