using FishNet.Object;
using UnityEngine;

namespace FishNet.Example.Scened
{
    public class PlayerController : NetworkBehaviour
    {
        private void Update()
        {
            if (!base.IsOwner)
                return;

            Move();
        }

        private void Move()
        {
            float hor = Input.GetAxisRaw("Horizontal");
            float ver = Input.GetAxisRaw("Vertical");
            transform.Translate(new Vector3(hor, 0, ver) * Time.deltaTime);
        }

    }


}
