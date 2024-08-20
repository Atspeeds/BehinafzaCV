using System;

namespace _0_FrameWork.FW.Domain
{
    public abstract class EntityBase<T>
    {
        public T KeyId { get; private set; }
        public DateTime CreationDate { get; private set; }

        public EntityBase()
        {
            CreationDate = DateTime.Now;
        }
    }
}
