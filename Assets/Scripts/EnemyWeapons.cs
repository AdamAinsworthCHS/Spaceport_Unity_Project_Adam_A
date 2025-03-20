using UnityEngine;

namespace System.Collections
{
    public class EnemyWeapons : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        public GameObject projectile;
        public GameObject enemy;
        private Vector3 offset = new Vector3(0, 0, 0);

        // Update is called once per frame
        void Update()
        {
            StartCoroutine(Wait());
            GameObject clone;
            clone = Instantiate(projectile, enemy.transform.position + offset, enemy.transform.rotation);
        }

        private IEnumerator Wait()
        {
            yield return new WaitForSeconds(3);
        }
    }
}
