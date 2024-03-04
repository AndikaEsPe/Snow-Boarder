using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustTrail;
    [SerializeField] Collider2D capsuleCollider;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground" && other.otherCollider.GetInstanceID() == capsuleCollider.GetInstanceID()) {
            dustTrail.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            dustTrail.Stop();
        }
    }
}
