using UnityEngine;
using UnityEngine.InputSystem;

public class Explosion : MonoBehaviour
{
    public Transform pointOfExplosion;
    public float explosionForce;
    public float explosionRadius;

    [SerializeField] private GameObject explosionPrefab;

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(explosionPrefab, pointOfExplosion);

            Collider[] colliders = Physics.OverlapSphere(pointOfExplosion.position, explosionRadius);
            foreach (Collider c in colliders)
            {
                if (c.attachedRigidbody != null)
                {
                    c.attachedRigidbody.AddExplosionForce(explosionForce, pointOfExplosion.position, explosionRadius);
                }
            }
        }
    }
}
