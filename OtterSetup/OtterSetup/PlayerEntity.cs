using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtterSetup
{
    class PlayerEntity : Entity
    {

        /// <summary>
        /// The current move speed of the Entity.
        /// </summary>
        public float MoveSpeed;

        /// <summary>
        /// The move speed for when the Entity is moving slowly.
        /// </summary>
        public const float MoveSpeedSlow = 5;
        /// <summary>
        /// The move speed for when the Entity is moving quickly.
        /// </summary>
        public const float MoveSpeedFast = 10;
        public PlayerEntity(float x, float y) : base(x, y)
        {

        }

        public override void Update()
        {
            base.Update();


            if (Input.KeyPressed(Key.Right))
            {
                this.X++;
            }
            if (Input.KeyPressed(Key.Left))
            {
                this.X--;
            }
            if (Input.KeyPressed(Key.Up))
            {
                this.Y++;
            }
        }
    }
}

