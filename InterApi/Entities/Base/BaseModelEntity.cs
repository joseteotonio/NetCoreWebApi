using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace InterApi.Entities.Base
{
    public class BaseModelEntity
    {
        public BaseModelEntity()
        {
        }

        [Key]
        [DataMember]
        public int Id { get; protected set; }

        [DataMember]
        public DateTime Created { get; protected set; }

        [DataMember]
        public DateTime Updated { get; protected set; }

        [DataMember]
        public bool Status { get; set; }
    }
}
