using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionDetection : MonoBehaviour

{
    // Update is called once per frame
    public Texture[] skin;
    public GameObject collided = null; 
    void Update()
    {
        if (gameObject.transform.position.y < 0 && collided != null)
        {
            int a = Random.Range(0, skin.Length);
            collided.transform.localScale += transform.localScale;
            collided.gameObject.GetComponent<Rigidbody>().mass += 1;
            MeshRenderer mesh = collided.GetComponent<MeshRenderer>();
            mesh.material.SetTexture("_MainTex", skin[a]);
            Destroy(gameObject);
        }
        else if (gameObject.transform.position.y < -2.2f)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ground"))
            collided = collision.gameObject;

    }
}
